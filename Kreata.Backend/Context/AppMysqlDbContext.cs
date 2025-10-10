using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public class AppMysqlDbContext : AppDbContext
    {
        public AppMysqlDbContext(DbContextOptions<AppMysqlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
