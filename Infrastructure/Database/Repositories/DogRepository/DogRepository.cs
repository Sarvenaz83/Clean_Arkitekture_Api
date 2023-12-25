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
    }
}
