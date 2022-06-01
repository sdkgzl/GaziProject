using GaziProject.GaziProjectDbContext;
using GaziProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GaziProject.Services
{
    public interface IBolumManager
    {
        List<Department> GetBolums();
        Department GetById(int Id);
        Department Create(Department entity);
        void Delete(Department entity);
        Department Update(Department entity);
       
    }
}
