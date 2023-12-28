using Application.Dtos;
using FluentValidation;

namespace Application.Validators.Bird
{
    public class BirdValidator : AbstractValidator<BirdDto>
    {
        public BirdValidator()
        {
            RuleFor(bird => bird.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(12).WithMessage("{PropertyName} must not exceed 100 characters.");
            RuleFor(bird => bird.CanFly)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();


            RuleFor(bird => bird.Color)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");


        }
    }
}
