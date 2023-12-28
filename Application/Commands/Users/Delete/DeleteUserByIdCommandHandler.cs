using Domain;
using Infrastructure.Database.Repositories.UserRepository;
using MediatR;

namespace Application.Commands.Users.Delete
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeletUserByIdCommand, bool>
    {
        private readonly IUserRepository? _userRepository;
        public DeleteUserByIdCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(DeletUserByIdCommand request, CancellationToken cancellationToken)
        {
            User? userToDelete = await _userRepository!.GetUserByIdAsync(request.UserId);

            if (userToDelete == null)
            {
                return false;
            }
            await _userRepository!.DeleteUserByIdAsync(request.UserId);
            return true;
        }
    }
}
