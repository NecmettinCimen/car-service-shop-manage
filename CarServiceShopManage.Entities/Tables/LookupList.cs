using System.ComponentModel.DataAnnotations;

namespace CarServiceShopManage.Entities.Tables
{
    public enum Lookup
    {
        Marka,
        Yakit,
        Il,
        Ilce,
        Bakim
    }
    public class LookupList : BaseEntity
    {
        [Required]
        public Lookup Tip { get; set; }
        [Required]
        [MaxLength(50)]
        public string Isim { get; set; }
        public int? ParentId { get; set; }
    }
}