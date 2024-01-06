using Infrastructure.Database.Repositories.AnimalUserRepository;
using MediatR;
using Domain.Models;

namespace Application.Commands.AnimalUser.DeleteAnimalUserByKey
{
    public class DeleteAnimalUserByKeyCommandHandler : IRequestHandler<DeleteAnimalUserByKeyCommand, bool>
    {
        private readonly IAnimalUserRepository? _animalUserRepository;

        public DeleteAnimalUserByKeyCommandHandler(IAnimalUserRepository animalUserRepository)
        {
            _animalUserRepository = animalUserRepository;
        }
        public async Task<bool> Handle(DeleteAnimalUserByKeyCommand request, CancellationToken cancellationToken)
        {
            var animalToDelete = await _animalUserRepository!.GetByKeyAsync(request.DeleteAnimalUserByKey);

            if (animalToDelete == null)
            {
                return false;
            }
            await _animalUserRepository!.DeleteAsync(request.DeleteAnimalUserByKey);
            return true;
        }
    }
}
