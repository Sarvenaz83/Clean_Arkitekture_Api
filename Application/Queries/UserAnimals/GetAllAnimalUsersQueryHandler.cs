using Application.Dtos;
using Infrastructure.Database.Repositories.AnimalUserRepository;
using MediatR;

namespace Application.Queries.UserAnimals
{
    public class GetAllAnimalUsersQueryHandler : IRequestHandler<GetAllAnimalUsersQuery, List<GetAnimalUserDto>>
    {
        private readonly IAnimalUserRepository? _animalUserRepository;

        public GetAllAnimalUsersQueryHandler(IAnimalUserRepository animalUserRepository)
        {
            _animalUserRepository = animalUserRepository;
        }
        public async Task<List<GetAnimalUserDto>> Handle(GetAllAnimalUsersQuery request, CancellationToken cancellationToken)
        {
            var animalUsers = await _animalUserRepository!.GetAllAnimalUsersAsync();
            return animalUsers.Select(animalUser => new GetAnimalUserDto
            {
                UserName = animalUser.UserName,
                AnimalName = animalUser.AnimalName,
                TogetherIndex = animalUser.TogetherIndex,
            }).ToList();
        }
    }
}
