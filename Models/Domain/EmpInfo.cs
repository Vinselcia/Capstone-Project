using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BlogWebApplication.Models.Domain
{
    public class EmpInfo
    {
        [Key]
        public int Id { get; set; }

        public string? EmailId { get; set; }

        public string? Name { get; set; }

        public DateTime? DateOfJoining { get; set; }

        public int? PassCode { get; set; }
    }
}
