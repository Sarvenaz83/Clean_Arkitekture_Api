﻿using Application.Commands.Dogs;
using Application.Commands.Dogs.DeleteDog;
using Application.Commands.Dogs.UpdateDog;
using Application.Dtos;
using Application.Queries.Dogs.GetAll;
using Application.Queries.Dogs.GetById;
using Application.Queries.Dogs.GetDogsByBreed;
using Application.Queries.Dogs.GetDogsByWeight;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database.Database;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers.DogsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        public readonly IMediator _mediator;
        public DogsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        // Get all dogs from database
        [HttpGet]
        [Route("getAllDogs")]
        public async Task<IActionResult> GetAllDogs()
        {
            return Ok(await _mediator.Send(new GetAllDogsQuery()));
            //return Ok("GET ALL DOGS");
        }

        // Get a dog by Id
        [HttpGet]
        [Route("getDogById/{dogId}")]
        public async Task<IActionResult> GetDogById(Guid dogId)
        {
            return Ok(await _mediator.Send(new GetDogByIdQuery(dogId)));
        }

        // Create a new dog 
        [HttpPost]
        [Route("addNewDog")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddDog([FromBody] DogDto newDog)
        {
            return Ok(await _mediator.Send(new AddDogCommand(newDog)));
        }

        // Update a specific dog
        [HttpPut]
        [Route("updateDog/{updatedDogId}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdateDog([FromBody] DogDto updatedDog, Guid updatedDogId)
        {
            return Ok(await _mediator.Send(new UpdateDogByIdCommand(updatedDog, updatedDogId)));
        }

        //Delete a dog by Id
        [HttpDelete]
        [Route("deleteDog/{deleteDogById}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteDog(Guid dogId)
        {
            return Ok(await _mediator.Send(new DeleteDogByIdCommand(dogId)));
        }

        //Get dogs by breed
        [HttpGet]
        [Route("getDogsByBreed/{breed}")]
        public async Task<IActionResult> GetDogsByBreed(string breed)
        {
            return Ok(await _mediator.Send(new GetDogsByBreedQuery(breed)));
        }

        //Get dogs by weight
        [HttpGet]
        [Route("getDogsByWeight/{weight}")]
        public async Task<IActionResult> GetDogsByWeight(int weight)
        {
            return Ok(await _mediator.Send(new GetDogsByWeightQuery(weight)));
        }

    }
}
