using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Data;
using System.Linq;
using App.Models;



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
            return base.Ok(_db.StudentsInfo);

        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id )
        {
            return base.Ok(_db.StudentsInfo.FirstOrDefault(s => s.Id == id));

        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentsInfo student)
        {
            _db.StudentsInfo.Add(student);
            _db.SaveChanges();
            return base.Ok("Student Added");

        }
        [HttpPut]
        public IActionResult UpdateStudent([FromBody] StudentsInfo student)
        {
            _db.StudentsInfo.Update(student);
            _db.SaveChanges();
            return base.Ok("Student Updated");

        }
        [HttpDelete]
        public IActionResult RemoveStudentByID([FromBody] StudentsInfo student)
        {
            _db.Attach(student);
            _db.StudentsInfo.Remove(student);
            _db.SaveChanges();
            return base.Ok("Student Removed");

        }
    }
}
