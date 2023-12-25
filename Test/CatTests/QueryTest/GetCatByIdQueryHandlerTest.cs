using Application.Queries.Cats.GetById;
using Domain.Models.Animal.CatModel;
using Infrastructure.Database.Repositories.CatRepository;
using Moq;

namespace Test.CatTests.QueryTest
{
    [TestFixture]
    public class GetCatByIdQueryHandlerTest
    {
        private Mock<ICatRepository> _mockCatRepository;
        private GetCatByIdQueryHandler _handler;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockCatRepository = new Mock<ICatRepository>();
            _handler = new GetCatByIdQueryHandler(_mockCatRepository.Object);
        }
        [Test]
        public async Task Handle_ReturnsCat_WhenCatExists()
        {
            // Arrange
            Guid catId = Guid.NewGuid();
            Cat expectedCat = new Cat { Id = catId, Name = "TestCat" };

            _mockCatRepository.Setup(catRepository => catRepository.GetCatByIdAsync(catId)).ReturnsAsync(expectedCat);

            // Act 
            Cat actualCat = await _handler.Handle(new GetCatByIdQuery(catId), CancellationToken.None);

            //Assert
            Assert.That(actualCat, Is.EqualTo(expectedCat));
        }

        [Test]
        public void Handle_ThrowsKeyNotFoundException_WhenCatDoesNotExist()
        {
            // Arrange
            Guid catId = Guid.NewGuid();

            _mockCatRepository.Setup(catRepository => catRepository.GetCatByIdAsync(catId)).ReturnsAsync((Cat?)null);

            // Act & Assert
            Assert.ThrowsAsync<KeyNotFoundException>(() => _handler.Handle(new GetCatByIdQuery(catId), CancellationToken.None));
        }

    }
}
