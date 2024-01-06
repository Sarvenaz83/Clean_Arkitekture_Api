using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        public Guid UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The username can't be empty")]
        public required string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The password can't be empty")]
        public string Password { get; set; } = string.Empty;

        //Navigation property for many-to-many relationship
        public ICollection<UserAnimal>? UserAnimals { get; set; }
    }
}
