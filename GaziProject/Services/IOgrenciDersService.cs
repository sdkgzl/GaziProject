using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public interface IOgrenciDersService 
    {
        List<OgrenciDers> GetOgrenciDersler();
        OgrenciDers GetById(int Id);
        OgrenciDers Create(OgrenciDers entity);
        void Delete(OgrenciDers entity);
        OgrenciDers Update(OgrenciDers entity);
    }
}
