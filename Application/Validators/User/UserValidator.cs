using Application.Dtos.User;
using FluentValidation;

namespace Application.Validators.User
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username)
                .NotEmpty().WithMessage("Username can't be empty.")
                .NotNull()
                .MinimumLength(5).WithMessage("Username must be at least 5 characters.")
                .MaximumLength(100).WithMessage("Username must not exceed 100 characters.");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password can't be empty.")
                .NotNull()
                .MinimumLength(5).WithMessage("Password must be at least 5 characters.")
                .MaximumLength(100).WithMessage("Password must not exceed 100 characters.")
                .Matches("[A-Z]").WithMessage("Password must contain at least 1 uppercase letter.")
                .Matches("[a-z]").WithMessage("Password must contain at least 1 lowercase letter.")
                .Matches("[0-9]").WithMessage("Password must contain at least 1 number.")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least 1 special character.");


        }
    }
}
