using Application.Queries.Dogs.GetById;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.DogRepository;
using Moq;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetDogByIdQueryHandlerTest
    {
        private GetDogByIdQueryHandler _handler;
        private Mock<IDogRepository> _mockDogRepository;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockDogRepository = new Mock<IDogRepository>();
            _handler = new GetDogByIdQueryHandler(_mockDogRepository.Object);
        }

        [Test]
        public async Task Handle_ReturnsDog_WhenDogExists()
        {
            // Arrange
            Guid guid = Guid.NewGuid();
            Dog expectedDog = new Dog { Id = guid, Name = "TestDog" };

            _mockDogRepository.Setup(dogRepository => dogRepository.GetDogByIdAsync(guid)).ReturnsAsync(expectedDog);

            // Act
            Dog actualDog = await _handler.Handle(new GetDogByIdQuery(guid), CancellationToken.None);

            // Assert
            Assert.That(actualDog, Is.EqualTo(expectedDog));
        }
    }
}
