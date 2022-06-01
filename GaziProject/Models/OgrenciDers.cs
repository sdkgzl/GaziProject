using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaziProject.Models
{
    public class OgrenciDers
    {        
        public int Id { get; set; }                
        public int KacKezAldi { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public double VizeNotu { get; set; }
        public double FinalNotu { get; set; }
        public string Sonuc { get; set; }        
        public virtual Ogrenci Ogrenci { get; set; }        
        public virtual Ders Ders { get; set; }
    }
}
