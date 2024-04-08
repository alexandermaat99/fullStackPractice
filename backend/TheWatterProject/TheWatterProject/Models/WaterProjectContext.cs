using Microsoft.EntityFrameworkCore;

namespace TheWatterProject.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext (DbContextOptions<WaterProjectContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}
