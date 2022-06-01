using GaziProject.GaziProjectDbContext;
using GaziProject.Models;

namespace GaziProject.Services
{
    public class OgrenciDersManager:IOgrenciDersManager
    {
        private readonly GaziProjectContext _dbContext;
        public OgrenciDersManager(GaziProjectContext gaziProjectContext)
        {
            _dbContext = gaziProjectContext;
        }
        public StudentLecture Create(StudentLecture entity)
        {
            StudentLecture crud = new StudentLecture();
            crud = _dbContext.StudentLectures.Add(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }

        public void Delete(StudentLecture entity)
        {
            _dbContext.StudentLectures.Remove(entity);
            _dbContext.SaveChanges();
        }

        public StudentLecture GetById(int Id)
        {
            StudentLecture crud = new StudentLecture();
            crud = _dbContext.StudentLectures.Find(Id);
            return crud;
        }

        public List<StudentLecture> GetOgrenciDersler()
        {
            List<StudentLecture> ogrenciDersler = new List<StudentLecture>();
            ogrenciDersler = _dbContext.StudentLectures.AsQueryable().ToList();
            return ogrenciDersler;
        }

        public StudentLecture Update(StudentLecture entity)
        {
            StudentLecture crud = new StudentLecture();
            crud = _dbContext.StudentLectures.Update(entity).Entity;
            _dbContext.SaveChanges();
            return crud;
        }
    }
}
