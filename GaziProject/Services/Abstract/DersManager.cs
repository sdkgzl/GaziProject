using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public class DersManager:IDersManager
    {
        private readonly GaziProjectContext _dbContext;
        public DersManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        public Lecture Create(Lecture entity)
        {
            Lecture crud = new Lecture();
            crud = _dbContext.Lectures.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }

        public void Delete(Lecture entity)
        {
            _dbContext.Lectures.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Lecture GetById(int Id)
        {
            Lecture crud = new Lecture();
            crud = _dbContext.Lectures.Find(Id);
            return crud;
        }

        public List<Lecture> GetDersler()
        {
            List<Lecture> dersler = new List<Lecture>();
            dersler = _dbContext.Lectures.AsQueryable().ToList();
            return dersler;
        }

        public Lecture Update(Lecture entity)
        {
            Lecture crud = new Lecture();
            crud = _dbContext.Lectures.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
