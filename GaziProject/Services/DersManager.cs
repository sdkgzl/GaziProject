using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public class DersManager:IDersService
    {
        private readonly GaziProjectContext _dbContext;
        public DersManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        public Ders Create(Ders entity)
        {
            Ders crud = new Ders();
            crud = _dbContext.Derss.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }

        public void Delete(Ders entity)
        {
            _dbContext.Derss.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Ders GetById(int Id)
        {
            Ders crud = new Ders();
            crud = _dbContext.Derss.Find(Id);
            return crud;
        }

        public List<Ders> GetDersler()
        {
            List<Ders> dersler = new List<Ders>();
            dersler = _dbContext.Derss.AsQueryable().ToList();
            return dersler;
        }

        public Ders Update(Ders entity)
        {
            Ders crud = new Ders();
            crud = _dbContext.Derss.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
