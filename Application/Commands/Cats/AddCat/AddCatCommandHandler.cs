using Domain.Models.Animal.CatModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.CatRepository;
using MediatR;

namespace Application.Commands.Cats.AddCat
{
    public sealed class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly ICatRepository _catRepository;

        public AddCatCommandHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }


        public async Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            Cat catToCreate = new()
            {
                AnimalId = Guid.NewGuid(),
                AnimalName = request.NewCat.Name,
                LikesToPlay = request.NewCat.LikesToPlay,
                Breed = request.NewCat.Breed,
                Weight = request.NewCat.Weight
            };

            await _catRepository.CreateCatAsync(catToCreate);

            return catToCreate;
        }
    }
}
