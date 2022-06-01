using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaziProject.Models
{
    public class Bolum
    {
        public int Id { get; set; }
        public string BolumKodu { get; set; }
        public string BolumAdi { get; set; }
        public string Telefon { get; set; }
        public virtual ICollection<Ogrenci> Ogrencis { get; set; }
    }
}
