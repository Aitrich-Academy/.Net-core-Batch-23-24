using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MVC_HireMeNow_Workshop.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MVC_HireMeNow_Workshop.Models.Entities
{
    public partial class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; } 

        public string? Gender { get; set; }

        public string? Location { get; set; }

        public string? Phone { get; set; }

        public string? password { get; set; }
        public Roles? Role { get; set; }

        public string? About { get; set; }

        public string? Designation { get; set; }
        public string? Status { get; set; }

        public byte[]? Image { get; set; }

        public DateTime? CreatedDate { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid? CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        

        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

       
    }
}
