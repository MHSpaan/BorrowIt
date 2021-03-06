﻿using BorrowIt.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BorrowIt.IntegrationTests
{
    public class TestSetup
    { 
        public TestSetup()
        {
            DestroyDatabase();
            CreateDatabase();
        }

        public void Dispose()
        {
            DestroyDatabase();
        }

        private static void CreateDatabase()
        {
            ExecuteSqlCommand(Master, $@"
                    CREATE DATABASE [BorrowIt]
                    ON (NAME = 'BorrowIt',
                    FILENAME = '{Filename}')");

            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = BorrowIt; Trusted_Connection = True; MultipleActiveResultSets = true").Options);
            context.Database.Migrate();
        }

        private static void DestroyDatabase()
        {
            var fileNames = ExecuteSqlQuery(Master, @"
                    SELECT [physical_name] FROM [sys].[master_files]
                    WHERE [database_id] = DB_ID('BorrowIt')",
                row => (string)row["physical_name"]);

            if (fileNames.Any())
            {
                ExecuteSqlCommand(Master, @"
                        ALTER DATABASE [BorrowIt] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                        EXEC sp_detach_db 'BorrowIt'");

                fileNames.ForEach(File.Delete);
            }
        }

        private static void ExecuteSqlCommand(
            SqlConnectionStringBuilder connectionStringBuilder,
            string commandText)
        {
            using (var connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = commandText;
                    command.ExecuteNonQuery();
                }
            }
        }

        private static List<T> ExecuteSqlQuery<T>(
            SqlConnectionStringBuilder connectionStringBuilder,
            string queryText,
            Func<SqlDataReader, T> read)
        {
            var result = new List<T>();
            using (var connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = queryText;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(read(reader));
                        }
                    }
                }
            }
            return result;
        }

        private static SqlConnectionStringBuilder Master =>
            new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "master",
                IntegratedSecurity = true
            };

        private static string Filename => Path.Combine(
            Path.GetDirectoryName(
                typeof(TestSetup).GetTypeInfo().Assembly.Location),
            "BorrowIt.mdf");
    }
}
