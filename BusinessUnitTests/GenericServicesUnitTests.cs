using BorrowIt.Data.Repositories;
using BusinessLogic.Services;
using BusinessLogic.Validators;
using Domain;
using Moq;
using System;
using Xunit;


namespace BorrowIt.UnitTests.Business
{
    [Trait("Methods", "GenericServices")]
    public sealed class GenericServicesUnitTests
    {
        private IServices<BaseClass> _sut;
        private Mock<IValidator<BaseClass>> _mockValidator;
        private Mock<IRepository<BaseClass>> _mockRepository;

        public GenericServicesUnitTests()
        {
            _mockRepository = new Mock<IRepository<BaseClass>>();
            _mockValidator = new Mock<IValidator<BaseClass>>();
            _mockValidator.Setup(a => a.IsValid(It.IsAny<BaseClass>())).Returns(true);
        }

        [Fact]
        public void WhenCreating_ThenRepositoryCreateHasBeenCalled()
        {
            _mockRepository.Setup(a => a.Create(It.IsAny<BaseClass>()));
            _sut = new GenericServices<BaseClass>(_mockRepository.Object, _mockValidator.Object);
            _sut.Create(It.IsAny<BaseClass>());
            _mockRepository.Verify(a => a.Create(It.IsAny<BaseClass>()));
        }

        [Fact]
        public void WhenDeleting_ThenRepositoryDeletingHasBeenCalled()
        {
            _mockRepository.Setup(a => a.Delete(It.IsAny<BaseClass>()));
            _sut = new GenericServices<BaseClass>(_mockRepository.Object, _mockValidator.Object);
            _sut.Delete(new Guid());
            _mockRepository.Verify(a => a.Delete(It.IsAny<BaseClass>()));
        }

        [Fact]
        public void WhenEditing_ThenRepositoryEditHasBeenCalled()
        {
            _mockRepository.Setup(a => a.Edit(It.IsAny<BaseClass>()));
            _sut = new GenericServices<BaseClass>(_mockRepository.Object, _mockValidator.Object);
            _sut.Edit(It.IsAny<BaseClass>());
            _mockRepository.Verify(a => a.Edit(It.IsAny<BaseClass>()));
        }

        [Fact]
        public void WhenGettingEntities_ThenRepositoryGetEntitiesHasBeenCalled()
        {
            _mockRepository.Setup(a => a.GetEntities());
            _sut = new GenericServices<BaseClass>(_mockRepository.Object, _mockValidator.Object);
            _sut.GetEntities();
            _mockRepository.Verify(a => a.GetEntities());
        }

        [Fact]
        public void WhenGettingById_ThenRepositoryGetEntitieByIdHasBeenCalled()
        {
            _mockRepository.Setup(a => a.GetEntityById(It.IsAny<Guid>()));
            _sut = new GenericServices<BaseClass>(_mockRepository.Object, _mockValidator.Object);
            _sut.GetEntityById(It.IsAny<Guid>());
            _mockRepository.Verify(a => a.GetEntityById(It.IsAny<Guid>()));
        }

    }
}
