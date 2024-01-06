using Infrastructure.Database.Repositories.AnimalUserRepository;
using Domain.Models;
using MediatR;

namespace Application.Commands.AnimalUser.AddAnimalUser
{
    public class AddAnimalUserCommandHandler : IRequestHandler<AddAnimalUserCommand, bool>
    {
        private readonly IAnimalUserRepository? _animalUserRepository;

        public AddAnimalUserCommandHandler(IAnimalUserRepository animalUserRepository)
        {
            _animalUserRepository = animalUserRepository;
        }
        public async Task<bool> Handle(AddAnimalUserCommand request, CancellationToken cancellationToken)
        {
            UserAnimal userAnimal = new()
            {
                UserId = request.NewAnimalUser.UserId,
                AnimalId = request.NewAnimalUser.AnimalId,
                TogetherIndex = request.NewAnimalUser.TogetherIndex,
            };
            await _animalUserRepository!.AddUserAnimalAsync(userAnimal);
            return true;
        }
    }
}
