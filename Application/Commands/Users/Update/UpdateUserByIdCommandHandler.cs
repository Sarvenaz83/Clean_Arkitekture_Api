using Domain;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;

namespace Application.Commands.Users.Update
{
    public class UpdateUserByIdCommandHandler : IRequestHandler<UpdateUserByIdCommand, User>
    {
        private readonly IUserRepository? _userRepository;

        public UpdateUserByIdCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }
        public async Task<User> Handle(UpdateUserByIdCommand request, CancellationToken cancellationToken)
        {
            var userToUpdate = await _userRepository!.GetUserByIdAsync(request.Id);
            if (userToUpdate != null)
            {
                await _userRepository!.UpdateUserAsync(userToUpdate);
                return userToUpdate;
            }
            return null!;
        }
    }
}
