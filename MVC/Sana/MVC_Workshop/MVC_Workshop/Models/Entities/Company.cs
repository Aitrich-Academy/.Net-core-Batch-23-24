using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Workshop.Models.Entities
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; } = null;
        public string? Website { get; set; } 
        public string? Phone { get; set; }
        public byte[]? Logo { get; set; }
        public string? About { get; set; }
        public string? Vision { get; set; }
        public string? Mission { get; set; }
        public string? Location { get; set; }
        public string? Address { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    }
}
