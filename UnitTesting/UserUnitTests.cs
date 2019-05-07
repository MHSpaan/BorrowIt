using Domain;
using System;
using Xunit;

namespace BorrowIt.UnitTests.Domain
{
    [Trait("Users", "Properties")]
    public class UserPropertiesUnitTests
    {
        protected readonly User _sut;
        public UserPropertiesUnitTests()
        {
            _sut = new User();
        }

        [Fact]
        public void WhenNewUser_ThenBranchIdIsEmpty()
        {
            // Arrange
            var expected = Guid.Empty;

            // Act
            var result = _sut.BranchId;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewUser_ThenEmailAddressIsNull()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.EmailAddress;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewUser_ThenFirstNameIsNull()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.FirstName;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewUser_ThenInfixIsNull()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.Infix;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewUser_ThenLastNameIsNull()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.LastName;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewUser_ThenPassWordIsNull()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.PassWord;

            // Assert
            Assert.Equal(expected, result);
        }
    }
    [Trait("Users", "Methods")]
    public class CarMethodsUnitTests
    {
    }

}
