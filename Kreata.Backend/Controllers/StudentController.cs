using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;

namespace Kreata.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private AppInMemoryContext _context=new AppInMemoryContext();

        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfStudent()
        {
            int count = await _context.Students.CountAsync();
            return Ok(new { count });
        }
    }
}
