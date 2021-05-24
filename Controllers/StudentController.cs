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

        public StudentController(ILogger<StudentController> logger, DBInteractor db)
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
