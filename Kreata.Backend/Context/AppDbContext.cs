using Kreata.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Diákok
        /// </summary>
        public DbSet<Student> Students { get; set; } 

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
