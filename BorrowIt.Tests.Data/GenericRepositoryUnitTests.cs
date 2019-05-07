using BorrowIt.Data;
using BorrowIt.Data.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace BorrowIt.UnitTests.Data
{
    [Trait("Methods", "GenericRepositories")]
    public sealed class GenericRepositoryUnitTests
    {
        private IRepository<BaseClass> _sut;
        private Mock<IApplicationDbContext> _mockContext;
        private Mock<DbSet<BaseClass>> _classMock;

        public GenericRepositoryUnitTests()
        {
            _mockContext = new Mock<IApplicationDbContext>();
            _classMock = new Mock<DbSet<BaseClass>>();
        }

        [Fact]
        public void WhenCreating_ThenContextAddHasBeenCalled()
        {
            _classMock.Setup(a => a.Add(It.IsAny<BaseClass>()));
            _sut = new GenericRepository<BaseClass>(_mockContext.Object, _classMock.Object);
            _sut.Create(It.IsAny<BaseClass>());
            _classMock.Verify(a => a.Add(It.IsAny<BaseClass>()));
        }

        [Fact]
        public void WhenDeleting_ThenContextRemoveHasBeenCalled()
        {
            _classMock.Setup(a => a.Remove(It.IsAny<BaseClass>()));
            _sut = new GenericRepository<BaseClass>(_mockContext.Object, _classMock.Object);
            _sut.Delete(It.IsAny<BaseClass>());
            _classMock.Verify(a => a.Remove(It.IsAny<BaseClass>()));
        }

        [Fact]
        public void WhenEditing_ThenContextUpdateHasBeenCalled()
        {
            _classMock.Setup(a => a.Update(It.IsAny<BaseClass>()));
            _sut = new GenericRepository<BaseClass>(_mockContext.Object, _classMock.Object);
            _sut.Edit(It.IsAny<BaseClass>());
            _classMock.Verify(a => a.Update(It.IsAny<BaseClass>()));
        }

        [Fact]
        public void WhenSaving_ThenContextSaveHasBeenCalled()
        {
            _mockContext.Setup(a => a.Save());
            _sut = new GenericRepository<BaseClass>(_mockContext.Object, _classMock.Object);
            _sut.Save();
            _mockContext.Verify(a => a.Save());
        }

        [Fact]
        public void WhenGettingEntities_ThenContextToListAsyncHasBeenCalled()
        {
            //_helperMock.Setup(a => a.GetEntities());
            //_sut = new GenericRepository<BaseClass>(_mockContext.Object as ApplicationDbContext, _classMock.Object);
            //_sut.GetEntities();
            //_helperMock.Verify(a => a.GetEntities());
        }
    }
}
