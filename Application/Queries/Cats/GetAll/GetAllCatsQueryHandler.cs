using Domain.Models.Animal.CatModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.CatRepository;
using MediatR;

namespace Application.Queries.Cats.GetAll
{
    public class GetAllCatsQueryHandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatsQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public async Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allCatsFromMyAppDbContext = await _catRepository.GetAllCatsAsync();
            return allCatsFromMyAppDbContext;
        }
    }
}
