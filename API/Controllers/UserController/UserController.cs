using Application.Commands.Users.Delete;
using Application.Commands.Users.Register;
using Application.Commands.Users.Update;
using Application.Dtos.User;
using Application.Queries.Users.GetAllUsersQuery;
using Application.Queries.Users.LoginUsers;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.UserController
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        internal readonly IMediator? _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getAllUsers")]
        public async Task<ActionResult> GetAllUsers()
        {
            try
            {
                var users = await _mediator!.Send(new GetAllUsersQuery());
                return users == null ? BadRequest("There are no users in the database") : Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginRequest? userToLogin)
        {

            try
            {
                var token = await _mediator!.Send(new LoginUserQuery { Username = userToLogin!.Username!, Password = userToLogin!.Password! })!;
                return userToLogin == null ? BadRequest("Invalid user login data") : Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }

        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] UserDto newUser)
        {

            try
            {
                var validationResult = await _mediator!.Send(new RegisterUserCommand(newUser));
                return newUser == null ? BadRequest("Invalid user registration data") : Ok(validationResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpPut("updateUser/{updatedUserId}")]
        [Authorize(Policy = "Admin")]
        public async Task<ActionResult> UpdateUser([FromRoute] UserDto updatedUser, Guid updatedUserId)
        {
            try
            {
                var user = await _mediator!.Send(new UpdateUserByIdCommand(updatedUser, updatedUserId));
                return user == null ? NotFound($"Invalid user id {updatedUserId} for updating.") : Ok(updatedUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deleteUser/{deleteUserId}")]
        [Authorize(Policy = "Admin")]
        public async Task<ActionResult> DeleteUser(Guid deleteUserId)
        {
            try
            {
                var result = await _mediator!.Send(new DeletUserByIdCommand(deleteUserId));
                return result == false ? NotFound($"Invalid user id {deleteUserId} for deleting.") : Ok($"User with Id '{deleteUserId}' has been deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }



    }
}
