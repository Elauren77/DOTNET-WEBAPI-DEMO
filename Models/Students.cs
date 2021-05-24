using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    public class StudentsInfo
    {
        public long Id { get; set; }
        public string stuPrefix { get; set; }
        public string stuFirstName { get; set; }
        public string stuLastName { get; set; }
        public int stuGrade { get; set; }
        public int stuAge { get; set; }
        public string stuDayScholar { get; set; }
        public string stuOptionalLang { get; set; }
    }
}