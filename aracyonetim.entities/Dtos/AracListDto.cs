using System;

namespace aracyonetim.entities.Dtos
{
    public class AracListDto
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Creator { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string TicariBinek { get; set; }
        public int Yil { get; set; }
        public int Km { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public string Plaka { get; set; }
        public string RuhsatSahibiAdSoyad { get; set; }
        public bool EnSonBakimYetkiliServis { get; set; }
        public DateTime? AlisTarihi { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public string SahibindenIlanNo { get; set; }
    }
}