﻿using System.ComponentModel.DataAnnotations;

namespace BlazorStudentApp.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public int Age { get; set; }
    }
}
