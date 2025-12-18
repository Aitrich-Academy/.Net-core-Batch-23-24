using System.ComponentModel.DataAnnotations;

namespace Blazor_New.Data.Models
{
    public class Book
    {
        [Key]
        [Required]

        public int BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Author { get; set; }

        public Book()
        {
        }
    }
}
