using Domain;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;


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
                UserId = Guid.NewGuid(),
                Username = request.NewUser.Username,
                Password = hashedPassword,

            };

            await _userRepository!.AddUserAsync(newUser);
            return newUser;

        }


    }
}
