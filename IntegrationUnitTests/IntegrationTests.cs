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

namespace BorrowIt.UnitTests.Integration
{
    public class IntegrationTests
    {
        private GenericController<Branch> _controller;
        private ApplicationDbContext _applicationDbContext;
        
        public IntegrationTests()
        {
            TestSetup setup = new TestSetup();
            DbContextOptionsBuilder<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = BorrowIt; Trusted_Connection = True; MultipleActiveResultSets = true");

            _applicationDbContext = new ApplicationDbContext(options.Options);
            var repository = new GenericRepository<Branch>(_applicationDbContext, _applicationDbContext.Branches);
            var service = new GenericServices<Branch>(repository, new BranchValidator());
            _controller = new GenericController<Branch>(service);
        }

        [Fact]
        public void Test1()
        {
            _controller.Create(new Branch());
        }
    }
}
