using Application.Commands.Cats.UpdateCat;
using Application.Dtos;
using Domain.Models.Animal.CatModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.CatRepository;
using Moq;

namespace Test.CatTests.CommandTest
{
    [TestFixture]
    public class UpdateCatByIdCommandHandlerTest
    {
        private UpdateCatByIdCommandHandler? _handler;
        private Mock<ICatRepository>? _catRepository;

        [SetUp]
        public void SetUp()
        {
            _catRepository = new Mock<ICatRepository>();
            _handler = new UpdateCatByIdCommandHandler(_catRepository.Object);
        }
        [Test]

        public async Task Handle_ShouldUpdateCat()
        {
            //Arrenge
            var catId = Guid.NewGuid();
            var catToUpdate = new Cat { AnimalId = catId, AnimalName = "Test", LikesToPlay = true, Breed = "TestCatBreed", Weight = 6 };
            var updatedCatDto = new CatDto { Name = "Updated", LikesToPlay = false, Breed = "UpdatedBreed", Weight = 8 };
            var command = new UpdateCatByIdCommand(updatedCatDto, catId);
            _catRepository!.Setup(repo => repo.GetCatByIdAsync(catId)).ReturnsAsync(catToUpdate);
            _catRepository!.Setup(repo => repo.UpdateCatByIdAsync(catId)).ReturnsAsync(catToUpdate);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _catRepository.Verify(repo => repo.GetCatByIdAsync(catId), Times.Once);
            _catRepository.Verify(repo => repo.UpdateCatByIdAsync(catId), Times.Once);
            Assert.That(result, Is.EqualTo(catToUpdate));


        }
        [Test]
        public async Task Handle_WhenNotExist_ShouldThrowException()
        {
            //Arrenge
            var catId = Guid.NewGuid();
            var updatedCatDto = new CatDto { Name = "Updated", LikesToPlay = false, Breed = "UpdatedBreed", Weight = 8 };
            var command = new UpdateCatByIdCommand(updatedCatDto, catId);
            _catRepository!.Setup(repo => repo.GetCatByIdAsync(catId)).ReturnsAsync((Cat?)null);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _catRepository.Verify(repo => repo.GetCatByIdAsync(catId), Times.Once);
            _catRepository.Verify(repo => repo.UpdateCatByIdAsync(catId), Times.Never);
            Assert.That(result, Is.Null);
        }


    }
}
