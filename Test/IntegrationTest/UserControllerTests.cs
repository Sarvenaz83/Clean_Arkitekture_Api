using Application.Queries.Users.GetAllUsersQuery;
using API.Controllers.UserController;
using Domain;
using MediatR;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace Test.IntegrationTest
{
    [TestFixture]
    public class UserControllerTests
    {
        [Test]
        public async Task GetAllUsersAsync_WhenCalled_ReturnsAllUsers()
        {
            // Arrange
            var mockMediator = new Mock<IMediator>();
            var users = new List<User> { new User(), new User() };
            mockMediator.Setup(mediator => mediator.Send(It.IsAny<GetAllUsersQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(users);
            var controller = new UserController(mockMediator.Object);

            // Act
            var result = await controller.GetAllUsers();

            // Assert
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var okResult = result as OkObjectResult;
            Assert.That(okResult!.Value, Is.InstanceOf<List<User>>());
            Assert.That(okResult.Value as List<User>, Is.EqualTo(users));
        }

    }
}
