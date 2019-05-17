using BorrowIt.Data.Repositories;
using BusinessLogic.Services;
using BusinessLogic.Validators;
using Domain;
using Moq;
using System;
using Xunit;


namespace BorrowIt.UnitTests.Business
{
    [Trait("Methods", "BranchServices")]
    public sealed class BranchServicesUnitTests
    {
        private IServices<Branch> _sut;
        private Mock<IValidator<Branch>> _mockValidator;
        private Mock<IRepository<Branch>> _mockRepository;

        public BranchServicesUnitTests()
        {
            _mockRepository = new Mock<IRepository<Branch>>();
            _mockValidator = new Mock<IValidator<Branch>>();
            _mockValidator.Setup(a => a.IsValid(It.IsAny<Branch>())).Returns(true);
        }

        [Fact]
        public void WhenCreating_ThenRepositoryCreateHasBeenCalled()
        {
            _mockRepository.Setup(a => a.Create(It.IsAny<Branch>()));
            _sut = new BranchServices(_mockRepository.Object, _mockValidator.Object);
            _sut.Create(It.IsAny<Branch>());
            _mockRepository.Verify(a => a.Create(It.IsAny<Branch>()));
        }

        [Fact]
        public void WhenDeleting_ThenRepositoryDeletingHasBeenCalled()
        {
            _mockRepository.Setup(a => a.Delete(It.IsAny<Branch>()));
            _sut = new BranchServices(_mockRepository.Object, _mockValidator.Object);
            _sut.Delete(new Guid());
            _mockRepository.Verify(a => a.Delete(It.IsAny<Branch>()));
        }

        [Fact]
        public void WhenEditing_ThenRepositoryEditHasBeenCalled()
        {
            _mockRepository.Setup(a => a.Edit(It.IsAny<Branch>()));
            _sut = new BranchServices(_mockRepository.Object, _mockValidator.Object);
            _sut.Edit(It.IsAny<Branch>());
            _mockRepository.Verify(a => a.Edit(It.IsAny<Branch>()));
        }

        [Fact]
        public void WhenGettingEntities_ThenRepositoryGetEntitiesHasBeenCalled()
        {
            _mockRepository.Setup(a => a.GetEntities());
            _sut = new BranchServices(_mockRepository.Object, _mockValidator.Object);
            _sut.GetEntities();
            _mockRepository.Verify(a => a.GetEntities());
        }

        [Fact]
        public void WhenGettingById_ThenRepositoryGetEntitieByIdHasBeenCalled()
        {
            _mockRepository.Setup(a => a.GetEntityById(It.IsAny<Guid>()));
            _sut = new BranchServices(_mockRepository.Object, _mockValidator.Object);
            _sut.GetEntityById(It.IsAny<Guid>());
            _mockRepository.Verify(a => a.GetEntityById(It.IsAny<Guid>()));
        }

    }
}
