﻿using Domain.Models.Animal.CatModel;

namespace Infrastructure.Database.Repositories.CatRepository
{
    public interface ICatRepository
    {
        Task<List<Cat>> GetAllCatsAsync();
        Task<Cat?> GetCatByIdAsync(Guid id);
        Task<Cat?> CreateCatAsync(Cat cat);
        Task<Cat?> UpdateCatByIdAsync(Guid id);
        Task<Cat?> DeleteCatByIdAsync(Guid id);
        Task<List<Cat>> GetCatsByBreedAsync(string breed);
        Task<List<Cat>> GetCatsByWeightAsync(int weight);

    }
}
