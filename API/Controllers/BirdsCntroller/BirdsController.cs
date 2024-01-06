using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.DeleteBird;
using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Application.Queries.Birds.GetAll;
using Application.Queries.Birds.GetByColor;
using Application.Queries.Birds.GetById;
using Application.Validators;
using Application.Validators.Bird;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers.BirdsCntroller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : Controller
    {
        internal readonly IMediator _mediator;
        internal readonly BirdValidator _birdValidator;
        internal readonly GuidValidator _guidValidator;
        public BirdsController(IMediator mediator, BirdValidator birdValidator, GuidValidator guidValidator)
        {
            _mediator = mediator;
            _birdValidator = birdValidator;
            _guidValidator = guidValidator;
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
            var guidValidationResult = _guidValidator.Validate(birdId);
            if (!guidValidationResult.IsValid)
            {
                return BadRequest(guidValidationResult.Errors.ConvertAll(errors => errors.ErrorMessage));
            }
            var bird = await _mediator.Send(new GetBirdByIdQuery(birdId));
            if (bird == null)
            {
                return NotFound();
            }
            try
            {
                return Ok(bird);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Create a new bird
        [HttpPost]
        [Route("addNewBird")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> AddBird([FromBody] BirdDto newBird)
        {
            var birdValidationResult = _birdValidator.Validate(newBird);
            if (!birdValidationResult.IsValid)
            {
                return BadRequest(birdValidationResult.Errors.ConvertAll(errors => errors.ErrorMessage));
            }
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
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdateBird([FromBody] BirdDto updatedBird, Guid updatedBirdId)
        {
            var guidValidator = _guidValidator.Validate(updatedBirdId);

            if (!guidValidator.IsValid)
            {
                return BadRequest(guidValidator.Errors.ConvertAll(errors => errors.ErrorMessage));
            }
            var birdValidator = _birdValidator.Validate(updatedBird);

            if (!birdValidator.IsValid)
            {
                return BadRequest(birdValidator.Errors.ConvertAll(errors => errors.ErrorMessage));
            }

            var bird = await _mediator.Send(new UpdateBirdByIdCommand(updatedBird, updatedBirdId));

            if (bird == null)
            {
                return NotFound($"Bird with Id: {updatedBirdId} does not exist in database");
            }

            try
            {
                return Ok(bird);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Delete a bird by Id
        [HttpDelete]
        [Route("deleteBird/{deleteBirdById}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteBird(Guid birdId)
        {
            var guidValidator = _guidValidator.Validate(birdId);

            if (!guidValidator.IsValid)
            {
                return BadRequest(guidValidator.Errors.ConvertAll(errors => errors.ErrorMessage));
            }

            try
            {
                await _mediator.Send(new DeleteBirdByIdCommand(birdId));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return NoContent();
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
