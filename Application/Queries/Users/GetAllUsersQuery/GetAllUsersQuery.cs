using Domain;
using MediatR;

namespace Application.Queries.Users.GetAllUsersQuery
{
    public class GetAllUsersQuery : IRequest<List<User>>
    {

    }
}
