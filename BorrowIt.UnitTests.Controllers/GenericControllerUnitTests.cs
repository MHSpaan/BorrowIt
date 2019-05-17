using BorrowIt.Controllers;
using BusinessLogic.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BorrowIt.UnitTests.Controllers
{
    [Trait("Methods", "BranchesController")]
    public class BranchesControllerUnitTests
    {
        private IController<Branch> _sut;
        private Mock<IServices<Branch>> _serviceMock;

        public BranchesControllerUnitTests()
        {
            _serviceMock = new Mock<IServices<Branch>>();
        }

        [Fact]
        public void WhenCreating_ThenReturningStatusCode201AndServicesCreateHasBeenCalled()
        {
            // Arrange
            _serviceMock.Setup(a => a.Create(It.IsAny<Branch>()));
            _sut = new BranchesController(_serviceMock.Object);
            var expected = new StatusCodeResult(201);

            // Act
            var result = _sut.Create(It.IsAny<Branch>()) as StatusCodeResult;

            // Assert
            _serviceMock.Verify(a => a.Create(It.IsAny<Branch>()));
            Assert.Equal(expected.StatusCode, result.StatusCode);
        }

        [Fact]
        public async Task WhenDeleting_ThenReturningStatusCode204AndServicesDeleteHasBeenCalled()
        {
            // Arrange
            _serviceMock.Setup(a => a.Delete(It.IsAny<Guid>())).Returns(Task.FromResult(new StatusCodeResult(204)));
            _sut = new BranchesController(_serviceMock.Object);
            var expected = new StatusCodeResult(204);

            // Act
            var result = await _sut.Delete(new Guid()) as StatusCodeResult;

            // Assert
            _serviceMock.Verify(a => a.Delete(It.IsAny<Guid>()));
            Assert.Equal(expected.StatusCode, result.StatusCode);
        }

        [Fact]
        public void WhenEditing_ThenReturningStatusCode204AndServicesEditHasBeenCalled()
        {
            // Arrange
            _serviceMock.Setup(a => a.Edit(It.IsAny<Branch>()));
            _sut = new BranchesController(_serviceMock.Object);
            var expected = new StatusCodeResult(204);

            // Act
            var result = _sut.Edit(It.IsAny<Branch>()) as StatusCodeResult;

            // Assert
            _serviceMock.Verify(a => a.Edit(It.IsAny<Branch>()));
            Assert.Equal(expected.StatusCode, result.StatusCode);
        }

        [Fact]
        public void WhenGettingById_ThenReturningBranchAndServicesGetEntityByIdHasBeenCalled()
        {
            // Arrange
            _serviceMock.Setup(a => a.GetEntityById(It.IsAny<Guid>())).Returns(Task.FromResult(It.IsAny<Branch>()));
            _sut = new BranchesController(_serviceMock.Object);
            var expected = It.IsAny<Branch>();

            // Act
            var result = _sut.GetById(It.IsAny<Guid>()).Result;

            // Assert
            _serviceMock.Verify(a => a.GetEntityById(It.IsAny<Guid>()));
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenGettingAll_ThenReturningListBranchAndServicesGetEntitiesHasBeenCalled()
        {
            // Arrange
            _serviceMock.Setup(a => a.GetEntities()).Returns(Task.FromResult(It.IsAny<ICollection<Branch>>()));
            _sut = new BranchesController(_serviceMock.Object);
            var expected = It.IsAny<ICollection<Branch>>();

            // Act
            var result = _sut.GetAll().Result;

            // Assert
            _serviceMock.Verify(a => a.GetEntities());
            Assert.Equal(expected, result);
        }
    }
}
