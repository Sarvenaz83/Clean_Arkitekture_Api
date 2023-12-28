using Application.Dtos.User;
using FluentValidation;

namespace Application.Validators.User
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MinimumLength(5).WithMessage("{PropertyName} must be at least 5 characters.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MinimumLength(5).WithMessage("{PropertyName} must be at least 5 characters.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.")
                .Matches("[A-Z]").WithMessage("{PropertyName} must contain at least 1 uppercase letter.")
                .Matches("[a-z]").WithMessage("{PropertyName} must contain at least 1 lowercase letter.")
                .Matches("[0-9]").WithMessage("{PropertyName} must contain at least 1 number.")
                .Matches("[^a-zA-Z0-9]").WithMessage("{PropertyName} must contain at least 1 special character.");


        }
    }
}
