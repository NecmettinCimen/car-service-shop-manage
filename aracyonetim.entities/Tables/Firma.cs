using System.ComponentModel.DataAnnotations;

namespace aracyonetim.entities.Tables
{
    public class Firma:BaseEntity
    {
    [Required]
    [MaxLength(100)]
        public string Isim { get; set; }
    }
}