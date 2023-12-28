using Domain;


namespace Infrastructure.Database.Repositories.UserRepository
{
    public interface IUserRepository
    {

        Task AddUserAsync(User userToAdd);
        Task UpdateUserAsync(User userToUpdateId);
        Task DeleteUserByIdAsync(Guid userToDeleteId);
        Task<User?> GetUserByIdAsync(Guid userId);
        Task<List<User>> GetAllUsersAsync();
        User GetUserByUsernameAndPasswordAsync(string username, string password);
    }
}
