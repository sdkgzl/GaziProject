using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public interface IDersManager
    {
        List<Lecture> GetDersler();
        Lecture GetById(int Id);
        Lecture Create(Lecture entity);
        void Delete(Lecture entity);
        Lecture Update(Lecture entity);
    }
}
