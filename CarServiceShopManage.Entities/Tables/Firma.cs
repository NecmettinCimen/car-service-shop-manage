using System.ComponentModel.DataAnnotations;

namespace CarServiceShopManage.Entities.Tables
{
    public class Firma : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Isim { get; set; }
    }
}