using Application.Dtos;
using FluentValidation;

namespace Application.Validators.Cat
{
    public class CatValidator : AbstractValidator<CatDto>
    {
        public CatValidator()
        {
            RuleFor(cat => cat.Name)
                .NotEmpty().WithMessage("Name can't be empty.")
                .NotNull()
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(cat => cat.Breed)
                .NotEmpty().WithMessage("Breed can't be empty.")
                .NotNull()
                .MaximumLength(50).WithMessage("Breed must not exceed 50 characters.");

            RuleFor(cat => cat.Weight)
                .NotEmpty().WithMessage("Weight can't be empty.")
                .NotNull()
                .GreaterThan(0).WithMessage("Weight must be greater than 0.");


        }
    }
}
