using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CFA.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // Primary Key
        [Required]
        public string Name { get; set; } // Product Name
        [Required]
        public decimal Price { get; set; } // Product Price
    }
}
