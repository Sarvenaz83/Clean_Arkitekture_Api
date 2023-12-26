using Domain.Models.Animal.DogModel;
using MediatR;

namespace Application.Queries.Dogs.GetDogsByBreed
{
    public class GetDogsByBreedQuery : IRequest<IEnumerable<Dog>>
    {
        public string Breed { get; set; } = string.Empty;

        public GetDogsByBreedQuery(string breed)
        {
            Breed = breed;
        }
    }
}
