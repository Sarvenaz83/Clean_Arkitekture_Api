using Application.Queries.Dogs.GetAll;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.DogRepository;
using MediatR;

namespace Application.Commands.Dogs
{
    public sealed class AddDogCommandHandler : IRequestHandler<AddDogCommand, Dog>
    {
        private readonly IDogRepository _dogRepository;

        public AddDogCommandHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task<Dog> Handle(AddDogCommand request, CancellationToken cancellationToken)
        {
            Dog dogToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewDog.Name,
                Breed = request.NewDog.Breed,
                Weight = request.NewDog.Weight
            };

            await _dogRepository.CreateDogAsync(dogToCreate);

            return dogToCreate;
        }
    }
}
