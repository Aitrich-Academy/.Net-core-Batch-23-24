using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MVC_HireMeNow_Workshop.Models.Entities
{
    public partial class Job
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? JobId { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public string? Experience { get; set; }

        public string? TypeOfWorkPlace { get; set; }

        public string? Salary { get; set; }

        public string? Responsibilities { get; set; }

        public string? JobType { get; set; }

        public int? VacanciesCount { get; set; }

        public int? AppliedCount { get; set; }

        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid? CompanyId { get; set; }
        public virtual Company? Company { get; set; }

        [ForeignKey(nameof(CreatedUser))]
        public Guid? CreatedBy { get; set; }
        public virtual User? CreatedUser { get; set; }
       


    }
}
