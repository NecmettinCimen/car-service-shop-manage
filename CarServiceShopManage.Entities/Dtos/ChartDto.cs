using CarServiceShopManage.Entities.Tables;

namespace CarServiceShopManage.Entities.Dtos
{
    public class ChartDto : BaseEntity
    {
        public string Isim { get; set; }
        public int Sayi { get; set; }
    }
}