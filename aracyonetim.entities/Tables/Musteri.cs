using System.ComponentModel.DataAnnotations;

namespace aracyonetim.entities.Tables
{
    public class Musteri : BaseEntity
    {
        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get; set; }

        [MaxLength(100)]
        public string SirketAd { get; set; }

        [MaxLength(15)]
        public string SirketTelefon { get; set; }

        [MaxLength(15)]
        public string EvTelefon { get; set; }

        [MaxLength(11)]
        public string TC { get; set; }

        public bool CinsiyetErkek { get; set; }

        public bool SirketAraci { get; set; }

        [MaxLength(250)]
        public string SirketAdres { get; set; }

    }
}