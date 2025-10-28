﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorActivity.Data.Models
{
    public class Book
    {
        [Key]
        [Required]
        
        public int BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Author {  get; set; }

        public Book()
        {
            
        }
    }
    
}
