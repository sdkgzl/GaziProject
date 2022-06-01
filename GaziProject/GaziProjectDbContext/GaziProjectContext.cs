using GaziProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GaziProject.GaziProjectDbContext
{
    public class GaziProjectContext:DbContext
    {
        protected readonly IConfiguration Configuration;
        public GaziProjectContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("GaziProjectDb"));
        }
       public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentLecture> StudentLectures { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
    }
}
