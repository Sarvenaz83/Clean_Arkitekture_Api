using Application.Commands.AnimalUser.AddAnimalUser;
using Application.Commands.AnimalUser.DeleteAnimalUserByKey;
using Application.Commands.AnimalUser.UpdateAnimalUserByUserId;
using Application.Dtos;
using Application.Queries.UserAnimals;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.AnimalUserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalUserController : ControllerBase
    {
        internal readonly IMediator _mediator;
        public AnimalUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getAllAnimalUsers")]
        public async Task<IActionResult> GetAllAnimalUsers()
        {
            try
            {
                var animalUsers = await _mediator.Send(new GetAllAnimalUsersQuery());
                return GetAllAnimalUsers == null ? NotFound("No animalUsers found.") : Ok(animalUsers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }

        }
        [HttpPost]
        [Route("addNewAnimalUser")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> AddAnimalUser([FromBody] AnimalUserDto newAnimalUser)
        {
            try
            {
                var result = await _mediator.Send(new AddAnimalUserCommand(newAnimalUser));
                return result == false ? BadRequest("Invalid animalUser registration data") : Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("updateAnimalUser")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdateAnimalUser([FromBody] UpdateAnimalUserByUserIdCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return command == null ? BadRequest("Invalid animalUser registration data") : Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deleteAnimalUser/{deleteAnimalUserKey}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteAnimalUser(Guid deleteAnimalUserKey)
        {
            try
            {
                var result = await _mediator.Send(new DeleteAnimalUserByKeyCommand(deleteAnimalUserKey));
                return result == false ? BadRequest("Invalid animalUser registration data") : Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

    }
}
