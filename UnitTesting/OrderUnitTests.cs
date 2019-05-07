using Domain;
using System;
using Xunit;

namespace BorrowIt.UnitTests.Domain
{
    [Trait("Orders", "Properties")]
    public class OrderUnitTests
    {
        protected readonly Order _sut;
        public OrderUnitTests()
        {
            _sut = new Order();
        }

        [Fact]
        public void WhenNewOrder_ThenApprovedIsFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            var result = _sut.Approved;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewOrder_ThenApprovedByUserIdIsEmpty()
        {
            // Arrange
            var expected = Guid.Empty;

            // Act
            var result = _sut.ApprovedByUserId;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenBranchIdIsEmpty()
        {
            // Arrange
            var expected = Guid.Empty;

            // Act
            var result = _sut.BranchId;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenProductIdIsEmpty()
        {
            // Arrange
            var expected = Guid.Empty;

            // Act
            var result = _sut.ProductId;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenReturnDateIsNewDateTime()
        {
            // Arrange
            DateTime expected = new DateTime();

            // Act
            var result = _sut.ReturnDate;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenStartDateIsNewDateTime()
        {
            // Arrange
            DateTime expected = new DateTime();

            // Act
            var result = _sut.StartDate;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenUserIdIsEmpty()
        {
            // Arrange
            var expected = Guid.Empty;

            // Act
            var result = _sut.UserId;

            // Assert
            Assert.Equal(expected, result);
        }
    }
    [Trait("Orders", "Methods")]
    public class OrderMethodsUnitTests
    {
    }
}
