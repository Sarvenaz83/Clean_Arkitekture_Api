using Domain.Models.Animal.BirdModel;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories.BirdRepository
{
    public class BirdRepository : IBirdRepository
    {
        private readonly MyAppDbContext _context;
        public BirdRepository(MyAppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Bird>> GetAllBirdsAsync()
        {
            return await _context.Birds.ToListAsync();
        }
        public async Task<Bird?> GetBirdByIdAsync(Guid id)
        {
            return await _context.Birds.FirstOrDefaultAsync(bird => bird.Id == id);
        }
    }
}
