using Domain;

namespace Infrastructure.Database.Repositories.Authorization
{
    public interface IAuthRepository
    {
        User AuthenticateUser(string username, string password);
        string GenerateJwtToken(User user);
    }
}
