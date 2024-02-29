using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogWebApplication.Models.Domain;

namespace BlogWebApplication.Data
{
    public class BlogWebApplicationContext : DbContext
    {
        public BlogWebApplicationContext (DbContextOptions<BlogWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<BlogWebApplication.Models.Domain.AdminInfo> AdminInfo { get; set; } = default!;
    }
}
