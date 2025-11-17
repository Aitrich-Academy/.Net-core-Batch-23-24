using System.ComponentModel.DataAnnotations;

namespace LoginRegister_Session.DTOs
{
    public class UserDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
