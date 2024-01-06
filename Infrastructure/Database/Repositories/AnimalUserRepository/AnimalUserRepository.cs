using Application.Dtos;
using Domain.Models;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Collections.Generic;

namespace Infrastructure.Database.Repositories.AnimalUserRepository
{
    public class AnimalUserRepository : IAnimalUserRepository
    {
        private readonly MyAppDbContext? _context;
        private readonly ILogger? _logger;

        public AnimalUserRepository(MyAppDbContext context)
        {
            _context = context;
            _logger = Log.ForContext<AnimalUserRepository>();
        }
        //Read
        public async Task<List<GetAnimalUserDto>> GetAllAnimalUsersAsync()
        {
            try
            {
                _logger!.Information("Getting all animal users...");

                var animalUsers = await _context!.UserAnimals
                    .Select(_animalUser => new GetAnimalUserDto
                    {
                        UserName = _animalUser.User!.Username,
                        AnimalName = _animalUser.Animal!.AnimalName,
                        TogetherIndex = _animalUser.TogetherIndex,
                    }).ToListAsync();
                _logger.Information($"Found {animalUsers.Count} animal users.");
                return animalUsers!;
            }
            catch (Exception e)
            {
                _logger!.Error(e, "Error while getting all animal users.");
                throw;
            }
        }

        public async Task<bool> AddUserAnimalAsync(UserAnimal userAnimal)
        {
            try
            {
                _logger!.Information("Adding user animal...");
                await _context!.UserAnimals.AddAsync(userAnimal);
                await _context!.SaveChangesAsync();
                _logger.Information($"Added user animal successfully");
                return true;
            }
            catch (Exception e)
            {
                _logger!.Error(e, "Error while adding user animal.");
                return false;
            }
        }

        public async Task<UserAnimal> GettAnimalUserByIdAsync(Guid animalUserId)
        {
            try
            {
                _logger!.Information($"Getting animal user by id: {animalUserId}...");
                var userAnimal = await _context!.UserAnimals
                    .FirstOrDefaultAsync(_animalUser => _animalUser.AnimalId == animalUserId);
                _logger.Information($"Found animal user with id: {animalUserId}");
                return userAnimal!;
            }
            catch (Exception e)
            {
                _logger!.Error(e, $"Error while getting animal user by id: {animalUserId}.");
                throw;
            }
        }

        public async Task UpdateAnimalUserAsync(UserAnimal userAnimal)
        {
            try
            {
                _logger!.Information($"Updating animal user with id: {userAnimal?.Key}...");
                _context!.UserAnimals.Update(userAnimal!);
                await _context!.SaveChangesAsync();
                _logger.Information($"Updated animal user with id: {userAnimal?.Key} successfully.");
            }
            catch (Exception e)
            {
                _logger!.Error(e, $"Error while updating animal user with id: {userAnimal.Key}.");
                throw;
            }
        }

        public async Task<UserAnimal> GetByKeyAsync(Guid key)
        {
            try
            {
                _logger.Information($"Getting animal user by key: {key}...");
                var userAnimal = await _context!.UserAnimals.FindAsync(key);
                _logger.Information($"Found animal user with key: {key}.");
                return userAnimal!;
            }
            catch (Exception e)
            {
                _logger.Error(e, $"Error while getting animal user by key: {key}.");
                throw;
            }
        }

        public async Task DeleteAsync(Guid Key)
        {
            try
            {
                _logger.Information($"Deleting animal user with key: {Key}...");
                var animalUserToDelete = await _context!.UserAnimals.FindAsync(Key) ?? throw new Exception("User not found!");
                _context!.UserAnimals.Remove(animalUserToDelete);
                await _context!.SaveChangesAsync();
                _logger.Information($"Deleted animal user with key: {Key} successfully.");
            }
            catch (Exception e)
            {
                _logger.Error(e, $"Error while deleting animal user with key: {Key}.");
                throw;
            }
        }





    }
}
