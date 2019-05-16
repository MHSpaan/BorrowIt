using BorrowIt.Controllers;
using BorrowIt.Data.Repositories;
using BusinessLogic.Services;
using BusinessLogic.Validators;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BorrowIt.UnitTests.Integration
{
    public class BranchIntegrationTests : IntegrationTests
    {
        protected GenericController<Branch> _controller;

        public BranchIntegrationTests()
        {
            var repository = new GenericRepository<Branch>(_applicationDbContext, _applicationDbContext.Branches);
            var service = new GenericServices<Branch>(repository, new BranchValidator());
            _controller = new GenericController<Branch>(service);
        }

        [Fact]
        public async void WhenCreate_ThenIdNotEmptyGUID()
        {
            var branch = new Branch()
            {
                Address = "TestAddress",
                City = "TestCity",
                Country = "TestCountry",
            };
            _controller.Create(branch);
            var results = await _controller.GetAll();
            var resultsList = results.ToList();
            Assert.NotEqual(Guid.Empty, resultsList.First().Id);
        }

        [Fact]
        public async void WhenCreate_ThenGetById()
        {
            var branch = new Branch()
            {
                Address = "TestAddress",
                City = "TestCity",
                Country = "TestCountry",
                Id = Guid.NewGuid()
            };
            _controller.Create(branch);
            var result = await _controller.GetById(branch.Id);
            Assert.Equal(branch, result);
        }

        [Fact]
        public async Task CanCreateAndRetrieveBranches()
        {
            var branches = new List<Branch>();

            var branch1 = new Branch()
            {
                Address = "TestAddress1",
                City = "TestCity1",
                Country = "TestCountry1",
                Id = Guid.NewGuid()
            };

            var branch2 = new Branch()
            {
                Address = "TestAddress2",
                City = "TestCity2",
                Country = "TestCountry2",
                Id = Guid.NewGuid()
            };

            branches.Add(branch1);
            branches.Add(branch2);
            _controller.Create(branch1);
            _controller.Create(branch2);
            var results = await _controller.GetAll();
            Assert.Equal(results.ToList(), branches);
        }
    }
}
