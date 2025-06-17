using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceShopManage.Entities.Tables
{
    public class BakimTalebi : BaseEntity
    {
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int AracId { get; set; }
        public Arac Arac { get; set; }

        [Required] public DateTime BakimTarihi { get; set; }

        [Required]
        [MaxLength(500)]
        public string Aciklama { get; set; }

        public int DurumId { get; set; }
        public LookupList Durum { get; set; }

        [MaxLength(500)]
        public string YetkiliServisAciklama { get; set; }
    }
}