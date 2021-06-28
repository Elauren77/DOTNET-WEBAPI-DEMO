using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Data;
using System.Linq;
using App.Models;


namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> _logger;
        private readonly DataContext _db;

        public TeacherController(ILogger<TeacherController> logger, DataContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IActionResult GetTeachers()
        {
            return base.Ok(_db.TeachersInfo);

        }

        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id )
        {
            return base.Ok(_db.TeachersInfo.FirstOrDefault(s => s.Id == id));

        }
        [HttpPost]
        public IActionResult AddTeacher([FromBody] TeachersInfo teacher)
        {
            _db.TeachersInfo.Add(teacher);
            _db.SaveChanges();
            return base.Ok("Teacher Added");

        }
        [HttpPut]
        public IActionResult UpdateTeacher([FromBody] TeachersInfo teacher)
        {
            _db.TeachersInfo.Update(teacher);
            _db.SaveChanges();
            return base.Ok("Teacher Updated");

        }
        [HttpDelete]
        public IActionResult RemoveTeacherByID([FromBody] TeachersInfo teacher)
        {
            _db.Attach(teacher);
            _db.TeachersInfo.Remove(teacher);
            _db.SaveChanges();
            return base.Ok("Teacher Removed");

        }
    }
namespace App.TeacherInfo
{


}

}
