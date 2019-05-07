using Domain;
using Xunit;

namespace BorrowIt.UnitTests.Domain
{
    [Trait("Branches", "Properties")]
    public class BranchUnitTests
    {
        protected readonly Branch _sut;
        public BranchUnitTests()
        {
            _sut = new Branch();
        }

        [Fact]
        public void WhenNewBranch_ThenAddressIsEmptyString()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.Address;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenCityIsEmptyString()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.City;

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenNewBranch_ThenCountryIsEmptyString()
        {
            // Arrange
            string expected = null;

            // Act
            var result = _sut.Country;

            // Assert
            Assert.Equal(expected, result);
        }
    }
    [Trait("Branches", "Methods")]
    public class BranchMethodsUnitTests
    {
    }
}
