using MVC_HireMeNow_Workshop.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVC_HireMeNow_Workshop.Models.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    
        [EmailAddress]
        public string? Email { get; set; } = null!;
        public string? Gender { get; set; }
        public string? Location { get; set; }
        public long? Phone { get; set; }

        public byte[]? Image { get; set; }
        public string? Password { get; set; }

        
        public Roles? Role { get; set; }
        public string? About { get; set; }


        public string? Token { get; set; }

        public UserDTO()
        {

        }
        public UserDTO(string firstName, string lastName, string email, string gender, string? location, long phone, string password, Roles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Location = location;
            Phone = phone;
            Password = password;
            Role = role;
        }
    }
}
