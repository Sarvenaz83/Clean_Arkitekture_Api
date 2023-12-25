using Domain.Models.Animal.BirdModel;
using Infrastructure.Database.Repositories.BirdRepository;
using MediatR;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQueryHandler : IRequestHandler<GetAllBirdsQuery, List<Bird>>
    {
        private readonly IBirdRepository _birdRepository;

        public GetAllBirdsQueryHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }
        public async Task<List<Bird>> Handle(GetAllBirdsQuery request, CancellationToken cancellationToken)
        {
            List<Bird> allBirdsFromMYAppDbContext = await _birdRepository.GetAllBirdsAsync();
            return allBirdsFromMYAppDbContext;
        }
    }
}
