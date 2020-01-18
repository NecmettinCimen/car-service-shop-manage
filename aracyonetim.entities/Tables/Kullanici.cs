using System.ComponentModel.DataAnnotations;

namespace aracyonetim.entities.Tables
{
    public class Kullanici:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string AdSoyad { get; set; }
        [Required]
        [MaxLength(100)]
        public string Eposta { get; set; }
        [Required]
        [MaxLength(50)]
        public string Parola { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telefon { get; set; }
        [MaxLength(100)]
        public string Unvan { get; set; }
        
        public int IlceId { get; set; }
        
        [MaxLength(250)]
        public string Adres { get; set; }
    }
}