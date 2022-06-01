using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaziProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentLastname { get; set; }
        public int DepartmentId { get; set; }        
        public DateTime AddedTime { get; set; }
        public double Average { get; set; }        
        public virtual Department Department { get; set; }
        public virtual ICollection<StudentLecture> StudentLectures { get; set; }
    }
}
