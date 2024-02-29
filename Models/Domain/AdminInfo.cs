using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BlogWebApplication.Models.Domain
{
    public class AdminInfo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string? EmailId { get; set; }

        public string? Password { get; set; }
    }
}
