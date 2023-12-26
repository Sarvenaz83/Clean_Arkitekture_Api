using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.DeleteBird;
using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Application.Queries.Birds.GetAll;
using Application.Queries.Birds.GetByColor;
using Application.Queries.Birds.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.BirdsCntroller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : Controller
    {
        internal readonly IMediator _mediator;
        public BirdsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Get all birds from database
        [HttpGet]
        [Route("getAllBirds")]
        public async Task<IActionResult> GetAllBirds()
        {
            //return Ok("GET ALL BIRDS");
            try
            {
                return Ok(await _mediator.Send(new GetAllBirdsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get a bird by Id
        [HttpGet]
        [Route("getBirdById/{birdId}")]
        public async Task<IActionResult> GetBirdById(Guid birdId)
        {
            try
            {
                return Ok(await _mediator.Send(new GetBirdByIdQuery(birdId)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Create a new bird
        [HttpPost]
        [Route("addNewBird")]
        public async Task<IActionResult> AddBird([FromBody] BirdDto newBird)
        {
            try
            {
                return Ok(await _mediator.Send(new AddBirdCommand(newBird)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Update a specific Bird
        [HttpPut]
        [Route("updateBird/{updatedBirdId}")]
        public async Task<IActionResult> UpdateBird([FromBody] BirdDto updatedBird, Guid updatedBirdId)
        {
            try
            {
                return Ok(await _mediator.Send(new UpdateBirdByIdCommand(updatedBirdId, updatedBird)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete a bird by Id
        [HttpDelete]
        [Route("deleteBird/{deleteBirdById}")]
        public async Task<IActionResult> DeleteBird(Guid birdId)
        {
            try
            {
                return Ok(await _mediator.Send(new DeleteBirdByIdCommand(birdId)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Get all birds by color
        [HttpGet]
        [Route("getBirdsByColor/{color}")]
        public async Task<IActionResult> GetBirdsByColor(string color)
        {
            try
            {
                return Ok(await _mediator.Send(new GetBirdsByColorQuery(color)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
