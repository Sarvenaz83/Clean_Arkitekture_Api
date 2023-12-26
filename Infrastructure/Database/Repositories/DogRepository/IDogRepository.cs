using Domain.Models.Animal.DogModel;

namespace Infrastructure.Database.Repositories.DogRepository
{
    public interface IDogRepository
    {
        Task<List<Dog>> GetAllDogsAsync();
        Task<Dog?> GetDogByIdAsync(Guid id);
        Task<Dog?> CreateDogAsync(Dog dog);
        Task<Dog?> UpdateDogByIdAsync(Guid id);
        Task<Dog?> DeleteDogByIdAsync(Guid id);
        Task<List<Dog>> GetDogsByBreedAsync(string breed);
        Task<List<Dog>> GetDogsByWeightAsync(int weight);

    }
}
