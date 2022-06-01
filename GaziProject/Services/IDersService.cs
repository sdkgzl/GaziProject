using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public interface IDersService
    {
        List<Ders> GetDersler();
        Ders GetById(int Id);
        Ders Create(Ders entity);
        void Delete(Ders entity);
        Ders Update(Ders entity);
    }
}
