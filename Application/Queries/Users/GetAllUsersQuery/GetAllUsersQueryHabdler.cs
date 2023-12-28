using Domain;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;

namespace Application.Queries.Users.GetAllUsersQuery
{
    public class GetAllUsersQueryHabdler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserRepository? _userRepository;

        public GetAllUsersQueryHabdler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            List<User> users = await _userRepository!.GetAllUsersAsync();
            return users;
        }
    }
}
