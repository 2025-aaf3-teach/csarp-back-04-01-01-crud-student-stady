using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public class AppInMemoryDbContext : AppDbContext
    {
        public AppInMemoryDbContext()
            : base(new DbContextOptionsBuilder<AppInMemoryDbContext>()
                  .UseInMemoryDatabase("TestDb")
              .Options)
        {
            Database.EnsureCreated();
        }

        public AppInMemoryDbContext(DbContextOptions<AppInMemoryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
