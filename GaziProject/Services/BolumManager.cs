using GaziProject.Models;
using GaziProject.GaziProjectDbContext;

namespace GaziProject.Services
{
    public class BolumManager:IBolumService
    {
        private readonly GaziProjectContext _dbContext;
        public BolumManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        
        public Bolum Create(Bolum entity)
        {
            Bolum crud = new Bolum();
            crud = _dbContext.Bolums.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }

        public void Delete(Bolum entity)
        {
            _dbContext.Bolums.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Bolum> GetBolums()
        {
            List<Bolum> bolums = new List<Bolum>();
            bolums = _dbContext.Bolums.AsQueryable().ToList();
            return bolums;
        }

        public Bolum GetById(int bolumId)
        {
            Bolum crud = new Bolum();
            crud = _dbContext.Bolums.Find(bolumId);
            return crud;
        }

        public Bolum Update(Bolum entity)
        {
            Bolum crud = new Bolum();
            crud = _dbContext.Bolums.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
