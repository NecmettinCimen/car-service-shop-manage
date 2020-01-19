using aracyonetim.entities.Tables;

namespace aracyonetim.entities.Dtos
{
    public class ChartDto:BaseEntity
    {
        public string Isim { get; set; }
        public int Sayi { get; set; }
    }
}