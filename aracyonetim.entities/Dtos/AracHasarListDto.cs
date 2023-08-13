using aracyonetim.entities.Tables;

namespace aracyonetim.entities.Dtos
{
    public class AracHasarListDto 
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public AracHasar AracHasar { get; set; }

        public string SagArkaCamurluk { get; set; }
        public string ArkaKaput { get; set; }
        public string SolArkaCamurluk { get; set; }
        public string SagArkaKapi { get; set; }
        public string SagOnKapi { get; set; }
        public string Tavan { get; set; }
        public string SolArkaKapi { get; set; }
        public string SolOnKapi { get; set; }
        public string SagOnCamurluk { get; set; }
        public string MotorKaputu { get; set; }
        public string SolOnCamurluk { get; set; }
        public string OnTampon { get; set; }
        public string ArkaTampon { get; set; }
    }
}