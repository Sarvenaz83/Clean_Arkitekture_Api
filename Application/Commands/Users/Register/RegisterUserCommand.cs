using Application.Dtos.User;
using Application.Exceptions.BadRequestException;
using Application.Validators;
using Domain;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands.Users.Register
{
    public class RegisterUserCommand : IRequest<User>, Ivalidate
    {
        public RegisterUserCommand(UserDto newUser)
        {
            NewUser = newUser;
        }
        public UserDto NewUser { get; }

        public void Validate()
        {
            var validationErrors = new List<string>();
            if (string.IsNullOrEmpty(NewUser.Username))
            {
                validationErrors.Add("Username can't be empty.");
            }
            if (string.IsNullOrEmpty(NewUser.Password))
            {
                validationErrors.Add("Password cannot be empty.");
            }

            if (validationErrors.Count > 0)
            {
                throw new BadRequestException("Validation failed", validationErrors);
            }
        }
    }
}
