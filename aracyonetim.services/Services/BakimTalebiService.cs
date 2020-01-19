using System.Linq;
using System.Threading.Tasks;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.services.Services
{
    public interface IBakimTalebiService
    {
        public  Task<DataGridDto<BakimTalebiListDto>> List(int firmaid);
        public Task<int> Save(BakimTalebi model);
        public Task<bool> Update(BakimTalebi model);
        public Task Delete(int id, int firmaid);
        public Task<BakimTalebi> Get(int id, int firmaid);
    }
    public class BakimTalebiService:IBakimTalebiService
    {
        private readonly IBakimTalebiRepository _bakimTalebiRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository;
        private readonly IAracRepository _aracRepository;
        private readonly IMailService _mailService;

        public BakimTalebiService(IBakimTalebiRepository bakimTalebiRepository,
            IKullaniciRepository kullaniciRepository,
            ILookupListRepository lookupListRepository,
            IAracRepository aracRepository,
            IMailService mailService)
        {
            _bakimTalebiRepository = bakimTalebiRepository;
            _kullaniciRepository = kullaniciRepository;
            _lookupListRepository = lookupListRepository;
            _aracRepository = aracRepository;
            _mailService = mailService;
        }

        public async Task<DataGridDto<BakimTalebiListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<BakimTalebiListDto>.Store((from a in _bakimTalebiRepository.All().Where(w=>w.FirmaId == firmaid)
                    join arac in _aracRepository.All() on a.AracId equals arac.Id
                    join marka in _lookupListRepository.All() on arac.MarkaId equals  marka.Id into markad
                    from marka in markad.DefaultIfEmpty()
                    join kullanici in _kullaniciRepository.All() on a.KullaniciId equals kullanici.Id
                    join d in _lookupListRepository.All() on a.DurumId equals d.Id
                    select new BakimTalebiListDto
                    {
                        Id = a.Id,
                       Marka = marka.Isim,
                       Model = arac.Model,
                       Plaka = arac.Plaka,
                       Tarih = a.BakimTarihi,
                       Telefon = kullanici.Telefon,
                       AdSoyad = kullanici.AdSoyad,
                       EnSonBakimYetkiliServis = arac.EnSonBakimYetkiliServis,
                       Durum = d.Isim
                    }
                    ));
        }

        public async Task<int> Save(BakimTalebi model)
        {
            return await _bakimTalebiRepository.Save(model);
        }

        public async Task<bool> Update(BakimTalebi model)
        {
            await _bakimTalebiRepository.Update(model);

            var durum = await _lookupListRepository.All().FirstAsync(f=>f.Id == model.DurumId);
            var kullanici = await _kullaniciRepository.All().FirstAsync(f => f.Id == model.KullaniciId);
            var arac = await _aracRepository.All().FirstAsync(f => f.Id == model.AracId);
            if (durum.Isim!="Bekliyor")
            {
                await _mailService.Send(kullanici.Eposta, "Bakım Talebiniz Hk.",
                        $"{arac.Plaka} plakalı aracınızın {model.BakimTarihi.ToString("dd.MM.yyyy")} tarihli bakım talebi yetkili servis tarafından {durum.Isim} durumuna güncellendi.\nYetkili servis açıklaması : {model.Aciklama}")
                    .ConfigureAwait(false);
            }
            
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await _bakimTalebiRepository.Delete(id, firmaid);
        }

        public async Task<BakimTalebi> Get(int id, int firmaid)
        {
            return await _bakimTalebiRepository.All().Where(f=>f.Id==id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}