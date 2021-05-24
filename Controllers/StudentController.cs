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
            try
            {
                return base.Ok(_studentService.GetStudents());
            }
            catch (Exception e)
            {
                return base.Problem(e.ToString());
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetStudentByID(int id)
        {
            try
            {
                return base.Ok(_studentService.GetStudentById(id));
            }
            catch (Exception e)
            {
                return base.Problem(e.ToString());
            }
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentsInfo student)
        {
            try
            {
                _studentService.AddStudent(student);
                return base.Ok("Student Added");
            }
            catch (Exception e)
            {
                return base.Problem(e.ToString());
            }
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] StudentsInfo student)
        {
            try
            {
                _studentService.UpdateStudent(student);
                return base.Ok("Student Updated");
            }
            catch (Exception e)
            {
                return base.Problem(e.ToString());
            }
        }

        [HttpDelete]
        public IActionResult RemoveStudentByID([FromBody] StudentsInfo student)
        {
            try
            {
                _studentService.DeleteStudent(student);
                return base.Ok("Student Removed");
            }
            catch (Exception e)
            {
                return base.Problem(e.ToString());
            }
        }
    }
}
