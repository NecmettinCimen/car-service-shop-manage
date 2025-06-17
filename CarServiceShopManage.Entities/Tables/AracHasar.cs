using System.ComponentModel.DataAnnotations;

namespace CarServiceShopManage.Entities.Tables
{
    public class AracHasar : BaseEntity
    {
        [Required]
        public int AracId { get; set; }
        public EAracHasar SagArkaCamurluk { get; set; }
        public EAracHasar ArkaKaput { get; set; }
        public EAracHasar SolArkaCamurluk { get; set; }
        public EAracHasar SagArkaKapi { get; set; }
        public EAracHasar SagOnKapi { get; set; }
        public EAracHasar Tavan { get; set; }
        public EAracHasar SolArkaKapi { get; set; }
        public EAracHasar SolOnKapi { get; set; }
        public EAracHasar SagOnCamurluk { get; set; }
        public EAracHasar MotorKaputu { get; set; }
        public EAracHasar SolOnCamurluk { get; set; }
        public EAracHasar OnTampon { get; set; }
        public EAracHasar ArkaTampon { get; set; }
    }

    public enum EAracHasar
    {
        Belirtilmemis,
        Orijinal,
        Boyali,
        LokalBoyali,
        Degismis
    }
}