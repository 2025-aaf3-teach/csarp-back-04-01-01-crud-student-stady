using Kreata.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Ide kerülnek a tesztadatok
            DateTime baseCreated = new DateTime(2025, 1, 1);

            List<Student> students = new List<Student>
            {
                new Student { Id = Guid.NewGuid(), FirstName = "Anna", LastName = "Kovács", BirthDate = new DateTime(2007, 5, 12) },
                new Student { Id = Guid.NewGuid(), FirstName = "Bence", LastName = "Szabó", BirthDate = new DateTime(2006, 11, 3) },
                new Student { Id = Guid.NewGuid(), FirstName = "Csilla", LastName = "Tóth", BirthDate = new DateTime(2008, 1, 27) },
                new Student { Id = Guid.NewGuid(), FirstName = "Dávid", LastName = "Varga", BirthDate = new DateTime(2007, 8, 9) },
                new Student { Id = Guid.NewGuid(), FirstName = "Eszter", LastName = "Nagy", BirthDate = new DateTime(2006, 2, 14) },
                new Student { Id = Guid.NewGuid(), FirstName = "Ferenc", LastName = "Kiss", BirthDate = new DateTime(2008, 4, 30) },
                new Student { Id = Guid.NewGuid(), FirstName = "Gábor", LastName = "Molnár", BirthDate = new DateTime(2007, 10, 21) },
                new Student { Id = Guid.NewGuid(), FirstName = "Hanna", LastName = "Horváth", BirthDate = new DateTime(2006, 7, 18) },
                new Student { Id = Guid.NewGuid(), FirstName = "István", LastName = "Balogh", BirthDate = new DateTime(2007, 12, 5) },
                new Student { Id = Guid.NewGuid(), FirstName = "Júlia", LastName = "Farkas", BirthDate = new DateTime(2008, 3, 22) }
            };



            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}
