using GaziProject.GaziProjectDbContext;
using GaziProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GaziProject.Services
{
    public interface IBolumService
    {
        List<Bolum> GetBolums();
        Bolum GetById(int Id);
        Bolum Create(Bolum entity);
        void Delete(Bolum entity);
        Bolum Update(Bolum entity);
       
    }
}
