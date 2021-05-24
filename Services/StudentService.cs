using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace App
{
    public class StudentService 
    {
        private readonly ILogger<StudentService> _logger;
        private readonly DBInteractor _db;
        public StudentService(ILogger<StudentService> logger, DBInteractor db)
        {
            _logger = logger;
            _db = db;
        }
    }
}