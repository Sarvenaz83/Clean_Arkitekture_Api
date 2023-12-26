using Domain.Models.Animal.DogModel;
using MediatR;

namespace Application.Queries.Dogs.GetAll
{
    public class GetAllDogsQuery : IRequest<List<Dog>>
    {
    }
}
