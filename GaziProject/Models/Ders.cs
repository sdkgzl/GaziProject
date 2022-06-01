using System.ComponentModel.DataAnnotations;

namespace GaziProject.Models
{
    public class Ders
    {
        public int Id { get; set; } 
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int Kredisi { get; set; }
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
    }
}
