using BorrowIt.Data;
using BorrowIt.Data.Repositories;
using BorrowIt.UnitTests.Data.Helpers;
using Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace BorrowIt.UnitTests.Data
{
    [Trait("Methods", "GenericRepositories")]
    public sealed class BranchRepositoryUnitTests
    {
        private IRepository<Branch> _sut;
        private Mock<IApplicationDbContext> _mockContext;
        private Mock<IRepositoryUnitTestsHelper> _mockHelper;

        public BranchRepositoryUnitTests()
        {
            _mockContext = new Mock<IApplicationDbContext>();
            _mockHelper = new Mock<IRepositoryUnitTestsHelper>();
        }

        [Fact]
        public void WhenCreating_ThenContextAddHasBeenCalled()
        {
            _mockContext.Setup(a => a.Branches.Add(It.IsAny<Branch>()));
            _sut = new BranchRepository(_mockContext.Object);
            _sut.Create(It.IsAny<Branch>());
            _mockContext.Verify(a => a.Branches.Add(It.IsAny<Branch>()));
        }

        [Fact]
        public void WhenDeleting_ThenContextRemoveHasBeenCalled()
        {
            _mockContext.Setup(a => a.Branches.Remove(It.IsAny<Branch>()));
            _sut = new BranchRepository(_mockContext.Object);
            _sut.Delete(It.IsAny<Branch>());
            _mockContext.Verify(a => a.Branches.Remove(It.IsAny<Branch>()));
        }

        [Fact]
        public void WhenEditing_ThenContextUpdateHasBeenCalled()
        {
            _mockContext.Setup(a => a.Branches.Update(It.IsAny<Branch>()));
            _sut = new BranchRepository(_mockContext.Object);
            _sut.Edit(It.IsAny<Branch>());
            _mockContext.Verify(a => a.Branches.Update(It.IsAny<Branch>()));
        }

        [Fact]
        public void WhenSaving_ThenContextSaveHasBeenCalled()
        {
            _mockContext.Setup(a => a.Save());
            _sut = new BranchRepository(_mockContext.Object);
            _sut.Save();
            _mockContext.Verify(a => a.Save());
        }

        [Fact]
        public void WhenGettingEntities_ThenHelperGetEntitiesHasBeenCalled()
        {
            // Question: The idea is to check if the ToListAsync() method has been called when using the GetEntities() method of the Repository.

            //_mockContext.Setup(a => a.Branches.ToListAsync());
            //_sut = new BranchRepository(_mockContext.Object);
            //var result = _sut.GetEntities();
            //_mockContext.Verify(a => a.Branches.ToListAsync());
        }

        [Fact]
        public void WhenGettingEntityById_ThenContextFindAsyncHasBeenCalled()
        {
            _mockContext.Setup(a => a.Branches.FindAsync(It.IsAny<Guid>()));
            _sut = new BranchRepository(_mockContext.Object);
            _sut.GetEntityById(It.IsAny<Guid>());
            _mockContext.Verify(a => a.Branches.FindAsync(It.IsAny<Guid>()));
        }
    }
}
