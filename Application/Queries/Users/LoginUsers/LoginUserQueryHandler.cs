using Infrastructure.Database.Repositories.Authorization;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;

namespace Application.Queries.Users.LoginUsers
{
    public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, string>
    {
        private readonly IAuthRepository? _authRepository;

        public LoginUserQueryHandler(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public Task<string> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = _authRepository!.AuthenticateUser(request.Username.ToLowerInvariant(), request.Password);

            if (user == null)
            {
                throw new ArgumentException("Invalid username or password");
            }

            string token = _authRepository.GenerateJwtToken(user);

            return Task.FromResult(token);
        }
    }
}
