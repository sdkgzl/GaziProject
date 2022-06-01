using GaziProject.GaziProjectDbContext;
using GaziProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GaziProject.Services
{
    public class OgrenciManager:IOgrenciManager
    {
        private readonly GaziProjectContext _dbContext;
        public OgrenciManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        public Student Create(Student entity)
        {               
            Student crud = new Student();
            crud = _dbContext.Students.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;

        }

        public void Delete(Student entity)
        {
            _dbContext.Students.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Student GetById(int Id)
        {
            Student crud = new Student();
            crud = _dbContext.Students.Find(Id);
            return crud;
        }

        public List<Student> GetOgrenciler()
        {
            List<Student> ogrenciler = new List<Student>();
            ogrenciler = _dbContext.Students.Include(x=>x.Department).AsQueryable().ToList();
            return ogrenciler;
        }

        public Student Update(Student entity)
        {
            Student crud = new Student();
            crud = _dbContext.Students.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
