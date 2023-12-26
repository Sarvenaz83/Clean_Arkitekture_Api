using Domain.Models.Animal.CatModel;
using Infrastructure.Database;
using Infrastructure.Database.Repositories.CatRepository;
using MediatR;

namespace Application.Commands.Cats.UpdateCat
{
    public class UpdateCatByIdCommandHandler : IRequestHandler<UpdateCatByIdCommand, Cat>
    {
        private readonly ICatRepository _catRepository;

        public UpdateCatByIdCommandHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository ?? throw new ArgumentNullException(nameof(catRepository));
        }

        public async Task<Cat> Handle(UpdateCatByIdCommand request, CancellationToken cancellationToken)
        {
            var catToUpdate = await _catRepository!.GetCatByIdAsync(request.Id);
            if (catToUpdate != null)
            {
                await _catRepository!.UpdateCatByIdAsync(request.Id);
                return catToUpdate;
            }
            return null!;
        }
    }
}
