using System.ComponentModel.DataAnnotations;

namespace MVC_Exercise_Company.Models
{
    public class Company
    {
        [Key]
       
        public Guid CompanyId { get; set; } = Guid.NewGuid();
        [Required]
        public string CompanyName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string About { get; set; }
        public string Vision { get; set; }
        public string Mission { get; set; }
        public ICollection<CompanyMember> Members { get; set; }
    }
}
