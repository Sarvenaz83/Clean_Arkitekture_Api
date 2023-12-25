using Domain.Models.Animal.CatModel;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories.CatRepository
{
    public class CatRepository : ICatRepository
    {
        private readonly MyAppDbContext _context;
        public CatRepository(MyAppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cat>> GetAllCatsAsync()
        {
            return await _context.Cats.ToListAsync();
        }
        public async Task<Cat?> GetCatByIdAsync(Guid id)
        {
            return await _context.Cats.FirstOrDefaultAsync(cat => cat.Id == id);
        }

    }
}
