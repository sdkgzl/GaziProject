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
       public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<OgrenciDers> OgrenciDerss { get; set; }
        public DbSet<Ders> Derss { get; set; }
    }
}
