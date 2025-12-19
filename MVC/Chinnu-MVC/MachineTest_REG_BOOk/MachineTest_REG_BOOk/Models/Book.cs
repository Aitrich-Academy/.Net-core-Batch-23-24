using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTest_REG_BOOk.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId {  get; set; }

        public virtual User User { get; set; }

    }
}
