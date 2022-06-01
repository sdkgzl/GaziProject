using GaziProject.Models;
using GaziProject.GaziProjectDbContext;

namespace GaziProject.Services
{
    public class BolumManager:IBolumManager
    {
        private readonly GaziProjectContext _dbContext;
        public BolumManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        
        public Department Create(Department entity)
        {
            Department crud = new Department();
            crud = _dbContext.Departments.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }

        public void Delete(Department entity)
        {
            _dbContext.Departments.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Department> GetBolums()
        {
            List<Department> bolums = new List<Department>();
            bolums = _dbContext.Departments.AsQueryable().ToList();
            return bolums;
        }

        public Department GetById(int bolumId)
        {
            Department crud = new Department();
            crud = _dbContext.Departments.Find(bolumId);
            return crud;
        }

        public Department Update(Department entity)
        {
            Department crud = new Department();
            crud = _dbContext.Departments.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
