using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogWebApplication.Models.Domain;

namespace BlogWebApplication.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogWebApplication.Models.Domain.EmpInfo> EmpInfo { get; set; } = default!;
    }
}
