﻿using Application.Dtos;
using Domain.Models.Animal.DogModel;
using MediatR;

namespace Application.Commands.Dogs.UpdateDog
{
    public class UpdateDogByIdCommand : IRequest<Dog>
    {
        public UpdateDogByIdCommand(DogDto updatedDog, Guid id)
        {
            UpdatedDog = updatedDog;
            Id = id;
        }

        public DogDto UpdatedDog { get; set; }
        public Guid Id { get; }
    }
}
