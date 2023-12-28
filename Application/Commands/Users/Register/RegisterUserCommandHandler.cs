using AutoMapper;
using Domain;
using FluentValidation;
using IdentityServer4.Services;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands.Users.Register
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, User>
    {
        private readonly IUserRepository? _userRepository;

        public RegisterUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.NewUser.Password);
            User newUser = new()
            {
                Id = Guid.NewGuid(),
                Username = request.NewUser.Username,
                Password = hashedPassword,

            };

            await _userRepository!.AddUserAsync(newUser);
            return newUser;

        }


    }
}
