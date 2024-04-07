using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }

        public DbSet<MarriottFood> Foods { get; set; }


    }
}
