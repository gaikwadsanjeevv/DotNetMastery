using Microsoft.EntityFrameworkCore;
using ScalableDotNetAPI.Models;

namespace ScalableDotNetAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
