using Application.Dtos;
using FluentValidation;

namespace Application.Validators.AnimalUser
{
    internal class AnimalUserValidator : AbstractValidator<AnimalUserDto>
    {
        public AnimalUserValidator()
        {
            Validate();
        }

        private void Validate()
        {
            RuleFor(animalUser => animalUser.UserId).NotEmpty().WithMessage("UserId is required");
            RuleFor(animalUser => animalUser.AnimalId).NotEmpty().WithMessage("Animal name is required");
            RuleFor(animalUser => animalUser.TogetherIndex).NotEmpty().WithMessage("Together index is required");
        }

    }
}
