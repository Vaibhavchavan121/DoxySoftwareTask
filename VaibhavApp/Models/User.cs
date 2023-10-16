﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VaibhavApp.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
      
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string Country { get; set; }
        [Required]
        [StringLength(255)]
        public string State { get; set; }
    }
}