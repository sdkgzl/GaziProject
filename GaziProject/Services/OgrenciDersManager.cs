using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public class OgrenciDersManager:IOgrenciDersService
    {
        private readonly GaziProjectContext _dbContext;
        public OgrenciDersManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        public OgrenciDers Create(OgrenciDers entity)
        {
            OgrenciDers crud = new OgrenciDers();
            crud = _dbContext.OgrenciDerss.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }

        public void Delete(OgrenciDers entity)
        {
            _dbContext.OgrenciDerss.Remove(entity);
            _dbContext.SaveChanges();
        }

        public OgrenciDers GetById(int Id)
        {
            OgrenciDers crud = new OgrenciDers();
            crud = _dbContext.OgrenciDerss.Find(Id);
            return crud;
        }

        public List<OgrenciDers> GetOgrenciDersler()
        {
            List<OgrenciDers> ogrenciDersler = new List<OgrenciDers>();
            ogrenciDersler = _dbContext.OgrenciDerss.AsQueryable().ToList();
            return ogrenciDersler;
        }

        public OgrenciDers Update(OgrenciDers entity)
        {
            OgrenciDers crud = new OgrenciDers();
            crud = _dbContext.OgrenciDerss.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
