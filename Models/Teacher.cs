namespace App.Models
{
    public class TeacherInfo
    {
        public long Id { get; set; }
        public string teaPrefix { get; set; }
        public string teaFirstName { get; set; } 
        public string teaLastName { get; set; }
        public int teaGrade { get; set; }
        public int teaAge { get; set; }
        public string teaDayScholar { get; set; }
        public string teaOptionalLang { get; set; }
    }
}