using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public class AppSqliteDbContext : AppDbContext
    {
        public AppSqliteDbContext(DbContextOptions<AppSqliteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
