using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaziProject.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public int OgrenciNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int BolumId { get; set; }
        public string BolumKoduId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public double Ortalama { get; set; }        
        public virtual Bolum Bolum { get; set; }
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
    }
}
