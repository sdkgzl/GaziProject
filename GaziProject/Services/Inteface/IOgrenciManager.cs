using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public interface IOgrenciManager
    {
        List<Student> GetOgrenciler();
        Student GetById(int Id);
        Student Create(Student entity);
        void Delete(Student entity);
        Student Update(Student entity);


    }
}
