using Domain.Models.Animal.DogModel;

namespace Infrastructure.Database.Repositories.DogRepository
{
    public interface IDogRepository
    {
        Task<List<Dog>> GetAllDogsAsync();
    }
}
