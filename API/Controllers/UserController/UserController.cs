using Application.Dtos;
using Domain;
using Domain.Models;
using Infrastructure.Database.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyAppDbContext _context;

        public UserController(MyAppDbContext context)
        {
            _context = context;
        }
        
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            string password = BCrypt.Net.BCrypt.HashPassword(request.Password);

            user.Username = request.Username;
            user.Password = password;

            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<User> Login(UserDto request)
        {
            if (user.Username != request.Username)
            {
                return BadRequest("User not found");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
            {
                return BadRequest("Password is wrong!");
            }
            string token = GenerateJWTToken(user);
            return Ok(token);
        }

        private string GenerateJWTToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "Admin"),
            };

            var key = Encoding.ASCII.GetBytes(
                _configuration["JWTToken:Token"]!);


            var token = new JwtSecurityToken
            (
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
        
        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.Include(_user => _user.UserAnimals).ThenInclude(_userAnimal => _userAnimal.Animal).ToListAsync();
        }

        //Post: api/User/{userId}/Animals/{animalId}
        [HttpPost("{userId}/Animals/{animalId}")]
        public async Task<ActionResult> PostUserAnimal(Guid userId, Guid animalId)
        {
            var userAnimal = new UserAnimal { UserId = userId, AnimalId = animalId };
            _context.UserAnimals.Add(userAnimal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserAnimal", new { id = userAnimal.UserId }, userAnimal);
        }

        // PUT: api/Users/{userId}/Animals/{animalId}
        [HttpPut("{userId}/Animals/{animalId}")]
        public async Task<IActionResult> PutUserAnimal(Guid userId, Guid animalId, UserAnimal userAnimal)
        {
            if (userId != userAnimal.UserId || animalId != userAnimal.AnimalId)
            {
                return BadRequest();
            }

            _context.Entry(userAnimal).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //DELETE: api/Users/{userId}/Animals/{animalId}
        [HttpDelete("{userId}/Animals/{animalId}")]
        public async Task<IActionResult> DeleteUserAnimal(Guid userId, Guid animalId)
        {
            var userAnimal = await _context.UserAnimals.FindAsync(userId, animalId);
            if (userAnimal == null)
            {
                return NotFound();
            }

            _context.UserAnimals.Remove(userAnimal);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}
