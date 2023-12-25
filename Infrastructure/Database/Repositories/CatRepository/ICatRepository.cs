using Domain.Models.Animal.CatModel;

namespace Infrastructure.Database.Repositories.CatRepository
{
    public interface ICatRepository
    {
        Task<List<Cat>> GetAllCatsAsync();
        Task<Cat?> GetCatByIdAsync(Guid id);

    }
}
