using Application.Queries.Birds.GetAll;
using Domain.Models.Animal.BirdModel;
using Infrastructure.Database.Repositories.BirdRepository;
using Moq;

namespace Test.BirdTests.QueryTest
{
    [TestFixture]
    public class GetAllBirdsQueryHandlerTest
    {
        private Mock<IBirdRepository>? _mockBirdRepository;
        private GetAllBirdsQueryHandler? _handler;

        [SetUp]
        public void SetUp()
        {
            _mockBirdRepository = new Mock<IBirdRepository>();
            _handler = new GetAllBirdsQueryHandler(_mockBirdRepository.Object);
        }

        [Test]
        public async Task Handle_ReturnsAllBirds()
        {
            //Arrange
            List<Bird> expectedBirds = new List<Bird>
            {
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Fench" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Owl" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "LittePitte" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "LovlyBoy" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Tittu" },
            };

            _mockBirdRepository!.Setup(repo => repo.GetAllBirdsAsync()).ReturnsAsync(expectedBirds);


            //Act
            List<Bird> actualBirds = await _handler!.Handle(new GetAllBirdsQuery(), CancellationToken.None);

            //Assert
            Assert.That(actualBirds, Is.EqualTo(expectedBirds));
        }
    }
}
