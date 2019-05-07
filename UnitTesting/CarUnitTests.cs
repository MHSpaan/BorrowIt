using Domain;
using System;
using Xunit;

namespace BorrowIt.UnitTests.Domain
{
    [Trait("Cars", "Properties")]
    public class CarUnitTests
    {
        protected readonly Car _sut;
        public CarUnitTests()
        {
            _sut = new Car();
        }

        [Fact]
        public void WhenNewCar_ThenCategoryIsCar()
        {
            // Arrange
            var expected = ProductCategoryEnum.Car;

            // Act
            var result = _sut.Category;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewCar_ThenValueIsZero()
        {
            // Arrange
            var expected = 0;

            // Act
            var result = _sut.Value;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewCar_ThenBranchIdIsZero()
        {
            // Arrange
            var expected = Guid.Empty;

            // Act
            var result = _sut.BranchId;

            // Assert
            Assert.Equal(expected, result);
        }
    }
    [Trait("Cars", "Methods")]
    public class UserMethodsUnitTests
    {
    }
}
