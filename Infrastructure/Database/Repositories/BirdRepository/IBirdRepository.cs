using Domain.Models.Animal.BirdModel;

namespace Infrastructure.Database.Repositories.BirdRepository
{
    public interface IBirdRepository
    {
        Task<List<Bird>> GetAllBirdsAsync();
        Task<Bird?> GetBirdByIdAsync(Guid id);
        Task<Bird?> CreateBirdAsync(Bird bird);
        Task<Bird?> UpdateBirdByIdAsync(Guid id);
        Task<Bird?> DeleteBirdByIdAsync(Guid id);
        Task<Bird?> GetBirdsByColor(Bird bird);
    }
}
