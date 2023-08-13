using System.ComponentModel.DataAnnotations;

namespace aracyonetim.entities.Tables
{
    public class Rol : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Isim { get; set; }
    }

    public class RolMenu : BaseEntity
    {
        [Required] public int MenuNo { get; set; }
        [Required]
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}