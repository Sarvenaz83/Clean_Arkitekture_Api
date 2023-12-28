using Domain;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Infrastructure.Database.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly MyAppDbContext? _context;
        private readonly ILogger? _logger;
        public UserRepository(MyAppDbContext context)
        {
            _context = context;
            _logger = Log.ForContext<UserRepository>();

        }
        public async Task AddUserAsync(User userToRegister)
        {
            try
            {
                _logger!.Information($"Adding user with username {userToRegister.Username}");
                _context!.Users.Add(userToRegister);
                await _context.SaveChangesAsync();
                _logger.Information($"User with username {userToRegister.Username} has been added");

            }
            catch (Exception e)
            {
                _logger!.Error(e, "An error occured while registering a user");
                throw;
            }
        }

        public async Task UpdateUserAsync(User userToUpdate)
        {
            try
            {
                _logger!.Information($"Updating user with Id: {userToUpdate.Id}");
                _context!.Users.Update(userToUpdate);
                await _context.SaveChangesAsync();
                _logger.Information($"User with Id: {userToUpdate} has been updated");
            }
            catch (Exception e)
            {
                _logger!.Error(e, $"An error occured while updating user with Id: {userToUpdate.Id}");
            }
        }
        public async Task DeleteUserByIdAsync(Guid userToDeleteId)
        {
            try
            {
                _logger!.Information($"Deleting user with Id: {userToDeleteId}");
                var userToDelete = await _context!.Users.FindAsync(userToDeleteId) ?? throw new Exception("User not exists");
                _context!.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
                _logger.Information($"User with Id: {userToDeleteId} has been deleted");
            }
            catch (Exception e)
            {
                _logger!.Error(e, $"An error occured while deleting user with Id: {userToDeleteId}");
                throw;
            }
        }
        public async Task<User?> GetUserByIdAsync(Guid userId)
        {
            try
            {
                _logger!.Information($"Getting user with Id: {userId}");
                var user = await _context!.Users.FindAsync(userId);
                _logger.Information($"User with Id: {userId} has been found");
                return user;
            }
            catch (Exception e)
            {
                _logger!.Error(e, $"An error occured while getting user with Id: {userId}");
                throw;
            }
        }
        public User GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            try
            {
                _logger!.Information($"Getting user with username: {username} and password: {password}");
                var user = _context!.Users.FirstOrDefault(user => user.Username == username && user.Password == password);
                _logger!.Information($"User with username: {username} has been found");
                return user!;
            }
            catch (Exception e)
            {
                _logger!.Error(e, $"An error occured while getting user with username: {username} and password: {password}.");
                throw;
            }
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                _logger!.Information("Getting all users from the database");
                var users = await _context!.Users.ToListAsync();
                _logger.Information($"All {users.Count} users have been found");
                return users;
            }
            catch (Exception e)
            {
                _logger!.Error(e, "An error occured while getting all users from the database");
                throw;
            }
        }
    }
}
