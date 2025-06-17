using System;

namespace aracyonetim.entities.Dtos
{
    public class BakimTalebiListDto
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool EnSonBakimYetkiliServis { get; set; }
    }
}