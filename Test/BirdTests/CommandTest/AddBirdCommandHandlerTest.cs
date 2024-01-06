using Application.Commands.Birds.AddBird;
using Application.Dtos;
using Domain.Models.Animal.BirdModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.BirdRepository;
using Moq;

namespace Test.BirdTests.CommandTest
{
    [TestFixture]
    public class AddBirdCommandHandlerTest
    {
        private AddBirdCommandHandler? _handler;
        private Mock<IBirdRepository>? _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new AddBirdCommandHandler(_birdRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_ShouldCreateBird()
        {
            //Arrange
            var birdDto = new BirdDto { Name = "NewBirdName", CanFly = true, Color = "Blue" };
            var command = new AddBirdCommand(birdDto);

            BirdDto createdBird = null!;
            _birdRepositoryMock!.Setup(repo => repo.CreateBirdAsync(It.IsAny<Bird>()))
                .Callback<Bird>(bird => createdBird = new BirdDto
                {
                    Name = bird.AnimalName,
                    CanFly = bird.CanFly,
                    Color = bird.Color
                });

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _birdRepositoryMock.Verify(repo => repo.CreateBirdAsync(It.IsAny<Bird>()), Times.Once);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.AnimalName, Is.EqualTo(birdDto.Name));
            Assert.That(result.CanFly, Is.EqualTo(birdDto.CanFly));
            Assert.That(result.Color, Is.EqualTo(birdDto.Color));
        }
    }
}
