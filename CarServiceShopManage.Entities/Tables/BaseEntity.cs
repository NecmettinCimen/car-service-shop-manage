using System;

namespace CarServiceShopManage.Entities.Tables
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public short Status { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? FirmaId { get; set; }
        public Firma Firma { get; set; }
    }
}