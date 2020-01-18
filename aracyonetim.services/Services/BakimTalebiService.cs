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
        public  Task<DataGridDto<BakimTalebiListDto>> List();
        public Task<int> Save(BakimTalebi model);
        public Task<bool> Update(BakimTalebi model);
        public Task Delete(int id);
        public Task<BakimTalebi> Get(int id);
    }
    public class BakimTalebiService:IBakimTalebiService
    {
        private readonly IBakimTalebiRepository _bakimTalebiRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository;
        private readonly IAracRepository _aracRepository;

        public BakimTalebiService(IBakimTalebiRepository bakimTalebiRepository,
            IKullaniciRepository kullaniciRepository,
            ILookupListRepository lookupListRepository,
            IAracRepository aracRepository)
        {
            _bakimTalebiRepository = bakimTalebiRepository;
            _kullaniciRepository = kullaniciRepository;
            _lookupListRepository = lookupListRepository;
            _aracRepository = aracRepository;
        }

        public async Task<DataGridDto<BakimTalebiListDto>> List()
        {
            return await GenerateDataGridDto<BakimTalebiListDto>.Store((from a in _bakimTalebiRepository.All()
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
            return true;
        }

        public async Task Delete(int id)
        {
            await _bakimTalebiRepository.Delete(id);
        }

        public async Task<BakimTalebi> Get(int id)
        {
            return await _bakimTalebiRepository.All().Where(f=>f.Id==id).FirstAsync();
        }
    }
}