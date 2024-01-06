using Application.Queries.Dogs;
using Application.Queries.Dogs.GetAll;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database.Repositories.DogRepository;
using Moq;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetAllDogsQueryHandlerTest
    {
        private Mock<IDogRepository>? _mockDogRepository;
        private GetAllDogsQueryHandler? _handler;

        [SetUp]
        public void SetUp()
        {
            _mockDogRepository = new Mock<IDogRepository>();
            _handler = new GetAllDogsQueryHandler(_mockDogRepository.Object);
        }

        [Test]
        public async Task Handle_ReturnsAllDogs()
        {
            //Arrange
            List<Dog> expectedDogs = new List<Dog>
            {
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Nonika" },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Mandy" },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Alex" },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Pettibell" },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Oscar" },
            };

            _mockDogRepository!.Setup(repo => repo.GetAllDogsAsync()).ReturnsAsync(expectedDogs);

            //Act
            List<Dog> actualDogs = await _handler!.Handle(new GetAllDogsQuery(), CancellationToken.None);

            //Assert
            Assert.That(actualDogs, Is.EqualTo(expectedDogs));
        }
    }
}
