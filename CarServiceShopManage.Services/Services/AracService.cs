using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace aracyonetim.services.Services
{
    public interface IAracService
    {
        public Task<DataGridDto<AracListDto>> List(int firmaid);
        public Task<DataGridDto<DxSelectDto>> Select(int firmaid);
        public Task<int> Save(Arac model);
        public Task<bool> Update(Arac model);
        public Task Delete(int id, int firmaid);
        public Task<Arac> Get(int id, int firmaid);
    }
    public class AracService : IAracService
    {
        private readonly IAracRepository _aracRepository;
        private readonly ILookupListRepository _lookupListRepository;
        private readonly IKullaniciRepository _kullaniciRepository;

        public AracService(IAracRepository aracRepository,
            ILookupListRepository lookupListRepository,
            IKullaniciRepository kullaniciRepository)
        {
            _aracRepository = aracRepository;
            _lookupListRepository = lookupListRepository;
            _kullaniciRepository = kullaniciRepository;
        }

        public async Task<DataGridDto<AracListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<AracListDto>.Store((from a in _aracRepository.All().Where(w => w.FirmaId == firmaid)
                                                                 join m in _lookupListRepository.All() on a.MarkaId equals m.Id into mn
                                                                 from m in mn.DefaultIfEmpty()
                                                                 join y in _lookupListRepository.All() on a.YakitId equals y.Id into yn
                                                                 from y in yn.DefaultIfEmpty()
                                                                 join u in _kullaniciRepository.All() on a.CreatorId equals u.Id
                                                                 select new AracListDto
                                                                 {
                                                                     Creator = u.AdSoyad,
                                                                     Id = a.Id,
                                                                     Km = a.Km,
                                                                     Marka = m.Isim,
                                                                     Model = a.Model,
                                                                     Plaka = a.Plaka,
                                                                     Vites = a.Otomatik ? "Otomaik" : "Manuel",
                                                                     Yakit = y.Isim,
                                                                     Yil = a.Yil,
                                                                     CreateDate = a.CreateDate,
                                                                     TicariBinek = a.Ticari ? "Ticari" : "Binek",
                                                                     RuhsatSahibiAdSoyad = a.RuhsatSahibiAdSoyad,
                                                                     EnSonBakimYetkiliServis = a.EnSonBakimYetkiliServis,
                                                                     AlisTarihi = a.AlisTarihi,
                                                                     SatisTarihi = a.SatisTarihi,
                                                                     SahibindenIlanNo = a.SahibindenIlanNo,
                                                                 }
                    ));
        }

        public async Task<DataGridDto<DxSelectDto>> Select(int firmaid)
        {
            return await GenerateDataGridDto<DxSelectDto>.Store(
                _aracRepository.All(firmaid).Select(s => new DxSelectDto { id = s.Id, text = s.Plaka, data = s }));
        }

        public async Task<int> Save(Arac model)
        {
            return await _aracRepository.Save(model);
        }

        public async Task<bool> Update(Arac model)
        {
            await _aracRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await _aracRepository.Delete(id, firmaid);
        }

        public async Task<Arac> Get(int id, int firmaid)
        {
            return await _aracRepository.Get(id, firmaid);
        }
    }
}