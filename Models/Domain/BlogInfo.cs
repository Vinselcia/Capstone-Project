using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BlogWebApplication.Models.Domain
{
    public class BlogInfo
    {
        [Key]
        public int BlogId { get; set; }

        public string? Title { get; set; }

        public string? Subject { get; set; }

        public DateTime? DateOfCreation { get; set; }

        public string? BlogUrl { get; set; }

        public string? EmpEmailId { get; set; }
    }
}
