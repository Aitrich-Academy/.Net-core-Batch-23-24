using System.ComponentModel.DataAnnotations;

namespace MVC_MachineTest.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Dept { get; set; }
    }
}
