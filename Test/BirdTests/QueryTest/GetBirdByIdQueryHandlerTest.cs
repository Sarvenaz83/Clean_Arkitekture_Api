using Application.Queries.Birds.GetById;
using Domain.Models.Animal.BirdModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.BirdRepository;
using Moq;

namespace Test.BirdTests.QueryTest
{
    [TestFixture]
    public class GetBirdByIdQueryHandlerTest
    {
        private GetBirdByIdQueryHandler _handler;
        private Mock<IBirdRepository> _mockBirdRepository;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockBirdRepository = new Mock<IBirdRepository>();
            _handler = new GetBirdByIdQueryHandler(_mockBirdRepository.Object);
        }
        [Test]
        public async Task Handle_ReturnsBirds_WhenBirdExists()
        {
            // Arrange
            Guid birdId = Guid.NewGuid();
            Bird expectedBird = new Bird { AnimalId = birdId, AnimalName = "TestBird" };

            _mockBirdRepository.Setup(birdRepository => birdRepository.GetBirdByIdAsync(birdId)).ReturnsAsync(expectedBird);

            // Act
            Bird actualBird = await _handler.Handle(new GetBirdByIdQuery(birdId), CancellationToken.None);

            // Assert
            Assert.That(actualBird, Is.EqualTo(expectedBird));
        }

        [Test]
        public void Handle_ThrowsKeyNotFoundException_WhenBirdDoesNotExist()
        {
            // Arrange
            Guid birdId = Guid.NewGuid();

            _mockBirdRepository.Setup(birdRepository => birdRepository.GetBirdByIdAsync(birdId)).ReturnsAsync((Bird?)null);

            // Act & Assert
            Assert.ThrowsAsync<KeyNotFoundException>(() => _handler.Handle(new GetBirdByIdQuery(birdId), CancellationToken.None));
        }
    }
}
