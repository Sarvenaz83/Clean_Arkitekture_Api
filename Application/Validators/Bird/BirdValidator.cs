using Application.Dtos;
using FluentValidation;

namespace Application.Validators.Bird
{
    public class BirdValidator : AbstractValidator<BirdDto>
    {
        public BirdValidator()
        {
            RuleFor(bird => bird.Name)
                .NotEmpty().WithMessage("Bird name Can not be empty.")
                .NotNull().WithMessage("Bird name Can not be null.")
                .MaximumLength(12).WithMessage("Bird name must not exceed 100 characters.");
            RuleFor(bird => bird.CanFly)
                .NotEmpty().WithMessage("CanFly can't be empty.")
                .NotNull().WithMessage("CanFly Can not be null.");


            RuleFor(bird => bird.Color)
                .NotEmpty().WithMessage("Bird color can't be empty.")
                .NotNull().WithMessage("Bird color Can not be null.")
                .MaximumLength(50).WithMessage("Bird color must not exceed 50 characters.");


        }
    }
}
