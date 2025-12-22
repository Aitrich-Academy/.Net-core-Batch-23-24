using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Exercise_Company.Models
{
    public class CompanyMember
    {
        [Key]
        public Guid MemberId { get; set; } = Guid.NewGuid();
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Designation { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
