using Application.Dtos.User;
using Domain;
using MediatR;

namespace Application.Commands.Users.Update
{
    public class UpdateUserByIdCommand : IRequest<User>
    {
        public UpdateUserByIdCommand(UserDto updatedUser, Guid id)
        {
            UpdatedUser = updatedUser;
            Id = id;
        }

        public UserDto UpdatedUser { get; set; }
        public Guid Id { get; }
    }
}
