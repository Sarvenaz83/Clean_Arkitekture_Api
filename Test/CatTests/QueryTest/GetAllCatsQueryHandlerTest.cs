﻿using Application.Queries.Cats.GetAll;
using Domain.Models.Animal.CatModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.CatRepository;
using Moq;

namespace Test.CatTests.QueryTest
{
    [TestFixture]
    public class GetAllCatsQueryHandlerTest
    {
        private Mock<ICatRepository>? _mockCatRepository;
        private GetAllCatsQueryHandler? _handler;

        [SetUp]
        public void SetUp()
        {
            _mockCatRepository = new Mock<ICatRepository>();
            _handler = new GetAllCatsQueryHandler(_mockCatRepository.Object);
        }

        [Test]
        public async Task Handle_GetAllCats_FromDatabase_ReturnsCorrect()
        {
            //Arrange
            List<Cat> expectedCats = new List<Cat>
            {
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Sezar" },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Simba" },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Misholak" },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Kattis" },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Lotta" },
            };

            _mockCatRepository!.Setup(repo => repo.GetAllCatsAsync()).ReturnsAsync(expectedCats);

            //Act
            List<Cat> actualCats = await _handler!.Handle(new GetAllCatsQuery(), CancellationToken.None);

            //Assert
            Assert.That(actualCats, Is.EqualTo(expectedCats));
        }
    }
}
