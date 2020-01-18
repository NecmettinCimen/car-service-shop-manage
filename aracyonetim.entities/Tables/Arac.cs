using System.ComponentModel.DataAnnotations;

namespace aracyonetim.entities.Tables
{
    public class Arac:BaseEntity
    {
        [Required]
        [MaxLength(20)]
        public string Plaka { get; set; }
        public int? MarkaId { get; set; }
        public LookupList Marka { get; set; }
        [MaxLength(100)]
        public string Model { get; set; }
        [MaxLength(50)]
        public string Motor { get; set; }
        public bool Ticari { get; set; }
        public int Yil { get; set; }
        public int Km { get; set; }
        public int? YakitId { get; set; }
        public LookupList Yakit { get; set; }
        public bool Otomatik { get; set; }
        public string RuhsatSahibiAdSoyad { get; set; }
        public bool EnSonBakimYetkiliServis { get; set; }
    }
}