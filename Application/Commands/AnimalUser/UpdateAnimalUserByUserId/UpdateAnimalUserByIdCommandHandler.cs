using Domain.Models;
using Infrastructure.Database.Repositories.AnimalUserRepository;
using MediatR;

namespace Application.Commands.AnimalUser.UpdateAnimalUserByUserId
{
    public class UpdateAnimalUserByIdCommandHandler : IRequestHandler<UpdateAnimalUserByUserIdCommand, bool>
    {
        private readonly IAnimalUserRepository? _animalUserRepository;

        public UpdateAnimalUserByIdCommandHandler(IAnimalUserRepository animalUserRepository)
        {
            _animalUserRepository = animalUserRepository;
        }
        public async Task<bool> Handle(UpdateAnimalUserByUserIdCommand request, CancellationToken cancellationToken)
        {
            UserAnimal userAnimal = await _animalUserRepository!.GettAnimalUserByIdAsync(request.AnimalUserId);

            if (userAnimal == null)
            {
                throw new DirectoryNotFoundException($"User animal with id: {request.AnimalUserId} not found.");
            }
            userAnimal.UserId = request.NewUserId;
            await _animalUserRepository!.UpdateAnimalUserAsync(userAnimal);
            return true;
        }
    }
}
