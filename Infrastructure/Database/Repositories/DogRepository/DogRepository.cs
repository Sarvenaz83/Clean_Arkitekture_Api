using Domain.Models.Animal.BirdModel;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories.DogRepository
{
    public class DogRepository : IDogRepository
    {
        private readonly MyAppDbContext _context;
        public DogRepository(MyAppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Dog>> GetAllDogsAsync()
        {
            return await _context.Dogs.ToListAsync();
        }
        public async Task<Dog?> GetDogByIdAsync(Guid id)
        {
            return await _context.Dogs.FirstOrDefaultAsync(dog => dog.Id == id);
        }
        public async Task<Dog?> CreateDogAsync(Dog dog)
        {
            _context.Dogs.Add(dog);
            await _context.SaveChangesAsync();
            return dog;

        }
        public async Task<Dog?> UpdateDogByIdAsync(Guid id)
        {
            Dog? dogToUpdate = await _context.Dogs.FirstOrDefaultAsync(dog => dog.Id == id);
            if (dogToUpdate != null)
            {
                _context.Dogs.Update(dogToUpdate);
                await _context.SaveChangesAsync();
                return dogToUpdate;
            }
            return null;
        }
        public async Task<Dog?> DeleteDogByIdAsync(Guid id)
        {
            Dog? dogToDelete = await _context.Dogs.FirstOrDefaultAsync(dog => dog.Id == id);
            if (dogToDelete != null)
            {
                _context.Dogs.Remove(dogToDelete);
                await _context.SaveChangesAsync();
                return dogToDelete;
            }
            return null;
        }
        public async Task<List<Dog>> GetDogsByBreedAsync(string breed)
        {
            return await _context.Dogs.Where(dog => dog.Breed == breed).ToListAsync();
        }
        public async Task<List<Dog>> GetDogsByWeightAsync(int weight)
        {
            return await _context.Dogs.Where(dog => dog.Weight == weight).ToListAsync();
        }
    }
}
