using System;

namespace aracyonetim.entities.Tables
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public short Status { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}