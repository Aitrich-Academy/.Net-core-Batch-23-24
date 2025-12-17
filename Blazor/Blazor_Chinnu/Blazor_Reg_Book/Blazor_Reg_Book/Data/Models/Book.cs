using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Blazor_Reg_Book.Data.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title {  get; set; }
        [Required]
        public string Author {  get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
    }
}
