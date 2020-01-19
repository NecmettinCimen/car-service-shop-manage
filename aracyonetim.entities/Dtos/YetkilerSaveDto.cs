using System.Collections.Generic;

namespace aracyonetim.entities.Dtos
{
    public class YetkilerSaveDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Menuler { get; set; }
        public List<DxSelectDto> MenuList { get; set; }
    }
}