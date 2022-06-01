using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public interface IOgrenciService
    {
        List<Ogrenci> GetOgrenciler();
        Ogrenci GetById(int Id);
        Ogrenci Create(Ogrenci entity);
        void Delete(Ogrenci entity);
        Ogrenci Update(Ogrenci entity);


    }
}
