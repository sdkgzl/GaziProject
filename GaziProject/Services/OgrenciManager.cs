using GaziProject.GaziProjectDbContext;
using GaziProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GaziProject.Services
{
    public class OgrenciManager:IOgrenciService
    {
        private readonly GaziProjectContext _dbContext;
        public OgrenciManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        public Ogrenci Create(Ogrenci entity)
        {               
            Ogrenci crud = new Ogrenci();
            crud = _dbContext.Ogrencis.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;

        }

        public void Delete(Ogrenci entity)
        {
            _dbContext.Ogrencis.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Ogrenci GetById(int Id)
        {
            Ogrenci crud = new Ogrenci();
            crud = _dbContext.Ogrencis.Find(Id);
            return crud;
        }

        public List<Ogrenci> GetOgrenciler()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler = _dbContext.Ogrencis.Include(x=>x.Bolum).AsQueryable().ToList();
            return ogrenciler;
        }

        public Ogrenci Update(Ogrenci entity)
        {
            Ogrenci crud = new Ogrenci();
            crud = _dbContext.Ogrencis.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
