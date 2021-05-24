using System; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly DBInteractor _db;
        private readonly StudentService _studentService;

        public StudentController(ILogger<StudentController> logger, DBInteractor db, StudentService studentService)
        {
            _logger = logger;
            _db = db;
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return base.Ok();
        }
    }
}
