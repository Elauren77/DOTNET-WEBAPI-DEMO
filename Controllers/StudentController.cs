using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Data;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly DataContext _db;

        public StudentController(ILogger<StudentController> logger, DataContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return base.Ok();
        }
    }
}
