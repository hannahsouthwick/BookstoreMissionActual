﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// scaffolded models
namespace BookstoreMission.Models
{
    public partial class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
    }
}
