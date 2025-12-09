using System.ComponentModel.DataAnnotations;

namespace WebApi_Login.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
