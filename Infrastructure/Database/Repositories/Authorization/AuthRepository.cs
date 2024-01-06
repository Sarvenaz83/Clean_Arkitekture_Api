using Domain;
using Infrastructure.Database.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Database.Repositories.Authorization
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IConfiguration? _configuration;
        private readonly MyAppDbContext? _context;

        public AuthRepository(IConfiguration configuration, MyAppDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public User AuthenticateUser(string username, string password)
        {
            var user = _context!.Users.FirstOrDefault(user => user.Username == username);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!VerifyPasswordHash(password, user.Password))
            {
                throw new Exception("Invalid password");
            }
            return user;
        }

        public string GenerateJwtToken(User user)
        {

            var key = Encoding.ASCII.GetBytes(_configuration!["JwtToken:Token"]!);

            var roles = GetUserRoles(user);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, roles)
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(
                                       new SymmetricSecurityKey(key),
                                                          SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
        private string GetUserRoles(User user)
        {

            if (user.Username.ToUpperInvariant() == "ADMIN")
            {
                return "Admin";
            }
            else
            {
                return "User";
            }
        }



        private bool VerifyPasswordHash(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }


    }
}
