using BorrowIt.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BorrowIt.UnitTests.Data
{
    [Trait("ApplicationDbContext", "Methods")]
    public sealed class ApplicationDbContextUnitTests
    {
        private readonly ApplicationDbContext _sut;

        public ApplicationDbContextUnitTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestApplicationDbContext")
                .Options;
            _sut = new ApplicationDbContext(options);
        }


        [Fact]
        public void WhenCreated_ThenContextCarsShouldNotBeNull()
        {
            // Arrange

            // Act
            var result = _sut.Cars;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void WhenCreated_ContextOrdersShouldNotBeNull()
        {
            // Arrange

            // Act
            var result = _sut.Orders;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void WhenCreated_ContextUsersShouldNotBeNull()
        {
            // Arrange

            // Act
            var result = _sut.Users;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void WhenCreated_ContextBranchesShouldNotBeNull()
        {
            // Arrange

            // Act
            var result = _sut.Branches;

            // Assert
            Assert.NotNull(result);
        }
    }
}
