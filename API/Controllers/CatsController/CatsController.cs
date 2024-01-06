using Application.Commands.Cats.AddCat;
using Application.Commands.Cats.DeleteCat;
using Application.Commands.Cats.UpdateCat;
using Application.Dtos;
using Application.Queries.Cats.GetAll;
using Application.Queries.Cats.GetById;
using Application.Queries.Cats.GetCatsByBreed;
using Application.Queries.Cats.GetCatsByWeight;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.CatsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        internal readonly IMediator _mediator;
        public CatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Get all cats from database
        [HttpGet]
        [Route("getAllCats")]
        public async Task<IActionResult> GetAllCats()
        {
            //return Ok("GET ALL CATS");
            return Ok(await _mediator.Send(new GetAllCatsQuery()));


        }

        //Get a cat by Id
        [HttpGet]
        [Route("getCatById/{catId}")]
        public async Task<IActionResult> GetCatById(Guid catId)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatByIdQuery(catId)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Create a new cat
        [HttpPost]
        [Route("addNewCat")]
        //[Authorize(Policy = "Admin")]
        public async Task<IActionResult> AddCat([FromBody] CatDto newCat)
        {
            try
            {
                return Ok(await _mediator.Send(new AddCatCommand(newCat)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Update a specific Cat
        [HttpPut]
        [Route("updateCat/{updatedCatId}")]
        //[Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdateCat([FromBody] CatDto updatedCat, Guid updatedCatId)
        {
            try
            {
                return Ok(await _mediator.Send(new UpdateCatByIdCommand(updatedCat, updatedCatId)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete a cat by Id
        [HttpDelete]
        [Route("deleteCat/{deleteCatById}")]
        //[Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteCat(Guid catId)
        {
            try
            {
                return Ok(await _mediator.Send(new DeleteCatByIdCommand(catId)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get cats by breed
        [HttpGet]
        [Route("getCatsByBreed/{catBreed}")]
        public async Task<IActionResult> GetCatsByBreed(string catBreed)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatsByBreedQuery(catBreed)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get cats by Weight
        [HttpGet]
        [Route("getCatsByWeight/{catWeight}")]
        public async Task<IActionResult> GetCatsByWeight(int catWeight)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatsByWeightQuery(catWeight)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}
