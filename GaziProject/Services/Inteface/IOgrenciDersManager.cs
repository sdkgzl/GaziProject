using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public interface IOgrenciDersManager 
    {
        List<StudentLecture> GetOgrenciDersler();
        StudentLecture GetById(int Id);
        StudentLecture Create(StudentLecture entity);
        void Delete(StudentLecture entity);
        StudentLecture Update(StudentLecture entity);
    }
}
