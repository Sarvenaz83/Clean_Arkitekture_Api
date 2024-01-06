﻿using Application.Dtos;
using Application.Validators;
using Application.Validators.AnimalUser;
using FluentValidation;
using MediatR;


namespace Application.Commands.AnimalUser.AddAnimalUser
{
    public class AddAnimalUserCommand : IRequest<bool>, Ivalidate
    {
        public AddAnimalUserCommand(AnimalUserDto newAnimalUser)
        {
            NewAnimalUser = newAnimalUser;
        }

        public AnimalUserDto NewAnimalUser { get; }

        public void Validate()
        {
            var validator = new AnimalUserValidator();
            var result = validator.Validate(NewAnimalUser);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
