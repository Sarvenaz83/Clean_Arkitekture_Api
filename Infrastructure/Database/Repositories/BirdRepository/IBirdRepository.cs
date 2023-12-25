using Domain.Models.Animal.BirdModel;

namespace Infrastructure.Database.Repositories.BirdRepository
{
    public interface IBirdRepository
    {
        Task<List<Bird>> GetAllBirdsAsync();
        Task<Bird?> GetBirdByIdAsync(Guid id);
    }
}
