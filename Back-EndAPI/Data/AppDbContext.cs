using ClassLibrary.Models;

namespace Back_EndAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Test> Tests => Set<Test>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }
}
