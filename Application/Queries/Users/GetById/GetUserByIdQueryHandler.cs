using Domain;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;

namespace Application.Queries.Users.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            User? wantedUser = await _userRepository.GetUserByIdAsync(request.Id);

            if (wantedUser == null)
            {
                throw new KeyNotFoundException($"No user found with the id {request.Id}");
            }
            return wantedUser;
        }
    }
}
