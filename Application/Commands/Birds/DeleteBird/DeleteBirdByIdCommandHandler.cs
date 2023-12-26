using Domain.Models.Animal.BirdModel;
using Infrastructure.Database.Repositories.BirdRepository;
using MediatR;

namespace Application.Commands.Birds.DeleteBird
{
    public class DeleteBirdByIdCommandHandler : IRequestHandler<DeleteBirdByIdCommand, Bird>
    {
        private readonly IBirdRepository? _birdRepository;

        public DeleteBirdByIdCommandHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository ?? throw new ArgumentNullException(nameof(birdRepository));
        }
        public async Task<Bird> Handle(DeleteBirdByIdCommand request, CancellationToken cancellationToken)
        {
            var birdToDelete = await _birdRepository!.GetBirdByIdAsync(request.Id);
            if (birdToDelete != null)
            {
                await _birdRepository!.DeleteBirdByIdAsync(request.Id);
                return birdToDelete;
            }
            return null!;

        }
    }
}
