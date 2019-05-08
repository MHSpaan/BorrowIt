using System;
using Xunit;
using BorrowIt.Controllers;
using Domain;
using BorrowIt.Data;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Services;
using BorrowIt.Data.Repositories;
using BusinessLogic.Validators;
using BorrowIt.IntegrationTests;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace BorrowIt.UnitTests.Integration
{
    public class IntegrationTests
    {
        protected ApplicationDbContext _applicationDbContext;

        public IntegrationTests()
        {
            TestSetup setup = new TestSetup();
            DbContextOptionsBuilder<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = BorrowIt; Trusted_Connection = True; MultipleActiveResultSets = true");
            _applicationDbContext = new ApplicationDbContext(options.Options);
        }
    }
}
