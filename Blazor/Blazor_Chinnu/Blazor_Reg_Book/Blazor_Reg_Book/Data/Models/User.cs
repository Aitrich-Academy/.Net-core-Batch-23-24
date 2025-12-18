using System.ComponentModel.DataAnnotations;

namespace Blazor_Reg_Book.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
