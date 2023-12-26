using Domain.Models.Animal.DogModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.DogRepository;
using MediatR;

namespace Application.Commands.Dogs.UpdateDog
{
    public class UpdateDogByIdCommandHandler : IRequestHandler<UpdateDogByIdCommand, Dog>
    {
        private readonly IDogRepository _dogRepository;

        public UpdateDogByIdCommandHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository ?? throw new ArgumentNullException(nameof(dogRepository));
        }
        public async Task<Dog> Handle(UpdateDogByIdCommand request, CancellationToken cancellationToken)
        {
            var dogToUpdate = await _dogRepository.GetDogByIdAsync(request.Id);
            if (dogToUpdate != null)
            {
                await _dogRepository.UpdateDogByIdAsync(request.Id);
                return dogToUpdate;
            }
            return null!;
        }
    }
}
