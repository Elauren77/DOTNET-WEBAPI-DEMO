namespace App.Models
{
    public class TeachersInfo
    {
        public long Id { get; set; }
        public string teaPref { get; set; }
        public string teaFirstName { get; set; } 
        public string teaLastName { get; set; }
        public int teaSubject { get; set; }
        public int teaAge { get; set; }
        public string teaOptionalLang { get; set; }
    }
}