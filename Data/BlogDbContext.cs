using BlogWebApplication.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApplication.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AdminInfo> AdminInfo{ get; set; }
        public DbSet<BlogInfo> BlogInfo { get; set; }
        public DbSet<EmpInfo> EmpInfo { get; set; }


    }
}
