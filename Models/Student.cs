﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstAspCore6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("Name",TypeName ="varchar(100)")]
        [Required]
        public string Name { get; set; }
        [Column("Gender", TypeName = "varchar(100)")]
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Standard { get; set; }
    }
}
