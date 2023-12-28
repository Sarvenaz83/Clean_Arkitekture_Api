using Application.Dtos;
using FluentValidation;

namespace Application.Validators.User
{
    public class AnimalValidator : AbstractValidator<AnimalDto>
    {
        public AnimalValidator()
        {
            RuleFor(animal => animal.Name)
                .NotEmpty().WithMessage("Animal Name can not be empty")
                .NotNull().WithMessage("Animal Name can not be NULL")
                .NotEqual("string", StringComparer.OrdinalIgnoreCase);
        }
    }
}
