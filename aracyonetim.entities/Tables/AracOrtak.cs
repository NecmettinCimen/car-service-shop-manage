using System.ComponentModel.DataAnnotations;

namespace aracyonetim.entities.Tables
{
    public class AracOrtak : BaseEntity
    {
        [Required]
        public int AracId { get; set; }
        public string OrtakAdi { get; set; }
        public double Oran { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
    }
}