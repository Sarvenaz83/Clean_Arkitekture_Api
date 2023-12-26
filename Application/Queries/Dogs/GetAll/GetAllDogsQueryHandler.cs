using Application.Queries.Dogs.GetAll;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database.Repositories.DogRepository;
using MediatR;

namespace Application.Queries.Dogs
{
    public sealed class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly IDogRepository _dogRepository;

        public GetAllDogsQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public async Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMyAppDbContext = await _dogRepository.GetAllDogsAsync();
            return allDogsFromMyAppDbContext;
        }
    }
}
