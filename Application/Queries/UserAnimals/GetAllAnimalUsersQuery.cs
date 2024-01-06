using Application.Dtos;
using MediatR;

namespace Application.Queries.UserAnimals
{
    public class GetAllAnimalUsersQuery : IRequest<List<GetAnimalUserDto>>
    {

    }
}
