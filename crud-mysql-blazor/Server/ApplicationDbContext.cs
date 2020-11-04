using blazor_mysql.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazor_mysql.Server
{
     public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}