using Microsoft.AspNetCore.Authorization.Infrastructure;
using MVC_Workshop.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Workshop.Models.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string? FirstName { get; set; }  
        public string? LastName { get; set; }
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public Roles? Role { get; set; }
        public string? About { get; set; }
        public string? Designation { get; set; }
        public string? Status { get; set; }
        public byte[]? Image { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
