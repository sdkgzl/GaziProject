using System.ComponentModel.DataAnnotations;

namespace GaziProject.Models
{
    public class Lecture
    {
        public int Id { get; set; } 
        public string LectureCode { get; set; }
        public string LectureName { get; set; }
        public int Credit { get; set; }
        public virtual ICollection<StudentLecture> StudentLectures { get; set; }
    }
}
