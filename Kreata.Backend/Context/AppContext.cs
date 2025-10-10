using Kreata.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public class AppContext : DbContext
    {
        /// <summary>
        /// Termékek
        /// </summary>
        public DbSet<Student> Students { get; set; }

        public AppContext(DbContextOptions options) : base(options)
        {
        }
    }
}
