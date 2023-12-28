using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.User
{
    public class UserDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The username cannot be empty")]
        public required string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The password cannot be empty")]
        public required string Password { get; set; }
    }
}
