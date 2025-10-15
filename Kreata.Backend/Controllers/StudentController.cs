using Kreata.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;

namespace Kreata.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private AppInMemoryDbContext _context = new AppInMemoryDbContext();

        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfStudent()
        {
            int count = await _context.Students.CountAsync();
            return Ok(new { count });
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _context.Students.ToListAsync());
        }

        // Törlés id alapján: DELETE (DELETE /api/student/{id})
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            // Azt lehet törölni ami van
            Student? student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
            // Ha nincs akkor nem lehet töröln
            if (student is null)
                return NotFound();
            // Törlés és contextus változásainak mentése
            // _context.Entry(student).State = EntityState.Deleted;
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
