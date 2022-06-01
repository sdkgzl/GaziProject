using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaziProject.Models
{
    public class StudentLecture
    {        
        public int Id { get; set; }                
        public int HowManyTimes { get; set; }
        public int StudentId { get; set; }
        public int LectureId { get; set; }
        public double MidTermNote { get; set; }
        public double FinalNote { get; set; }
        public string Result { get; set; }        
        public virtual Student Student { get; set; }        
        public virtual Lecture Lecture { get; set; }
    }
}
