namespace aracyonetim.entities.Dtos
{
    public class Menu
    {
        public int No { get; set; }
        public string Adres { get; set; }
        public string Icon { get; set; }
        public string Isim { get; set; }
        public string Rol { get; set; }
    }
    public class MenuManager
    {
        public static Menu[] MenuList =
        {
            new Menu {No = 1, Adres = "/Home", Icon = "pie-chart", Isim = "Anasayfa"},
            new Menu {No = 2, Adres = "/Araclar", Icon = "activity", Isim = "Araç Yönetimi"},
            new Menu {No = 2, Adres = "/AracOrtaklar", Icon = "activity", Isim = "Araç Ortak Yönetimi"},
            new Menu {No = 2, Adres = "/AracHasar", Icon = "activity", Isim = "Araç Hasar Yönetimi"},
            new Menu {No = 2, Adres = "/AracGider", Icon = "activity", Isim = "Araç Gider Yönetimi"},
            new Menu {No = 3, Adres = "/Musteriler", Icon = "globe", Isim = "Müşteri Yönetimi"},
            new Menu {No = 4, Adres = "/BakimTalebi", Icon = "layers", Isim = "Bakım Talebi Yönetimi"},
            new Menu {No = 5, Adres = "/YetkiliServis", Icon = "life-buoy", Isim = "Yetkili Servis Yönetimi"},
            new Menu {No = 6, Adres = "/Kullanicilar", Icon = "users", Isim = "Kullanıcı Yönetimi"},
            new Menu {No = 7, Adres = "/Yetkiler", Icon = "message-square", Isim = "Yetki Tanımlamaları Yönetimi"}
        };
    }
}