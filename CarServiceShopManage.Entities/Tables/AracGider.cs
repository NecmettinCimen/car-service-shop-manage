using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceShopManage.Entities.Tables
{
    public class AracGider : BaseEntity
    {
        [Required]
        public int AracId { get; set; }
        public string GiderTip { get; set; }
        public double? Fiyat { get; set; }
        public DateTime? GiderTarih { get; set; }
        public string Aciklama { get; set; }
    }
}