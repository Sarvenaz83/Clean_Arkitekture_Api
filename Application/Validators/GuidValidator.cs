using FluentValidation;

namespace Application.Validators
{
    public class GuidValidator : AbstractValidator<Guid>
    {
        public void Validate()
        {
            RuleFor(guid => guid)
                .NotEmpty().WithMessage("Guid should not be empty.")
                .NotNull().WithMessage("Guid should not be null.")
                .NotEqual(Guid.Empty).WithMessage("Guid should not be empty.");

        }
    }
}
