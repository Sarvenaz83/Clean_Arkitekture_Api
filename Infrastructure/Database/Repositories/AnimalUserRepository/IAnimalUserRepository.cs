using Application.Dtos;
using Domain.Models;
namespace Infrastructure.Database.Repositories.AnimalUserRepository
{
    public interface IAnimalUserRepository
    {
        Task<List<GetAnimalUserDto>> GetAllAnimalUsersAsync();

        Task<bool> AddUserAnimalAsync(UserAnimal userAnimal);
        Task<UserAnimal> GettAnimalUserByIdAsync(Guid animalUserId);
        Task UpdateAnimalUserAsync(UserAnimal userAnimal);
        Task<UserAnimal> GetByKeyAsync(Guid key);
        Task DeleteAsync(Guid key);

    }
}
