using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace aracyonetim.services.Services
{
    public interface IMusteriService
    {
        public Task<DataGridDto<MusteriListDto>> List(int firmaid);
        public Task<int> Save(Musteri model);
        public Task<bool> Update(Musteri model);
        public Task Delete(int id, int firmaid);
        public Task<Musteri> Get(int id, int firmaid);
    }
    public class MusteriService : IMusteriService
    {
        private readonly IMusteriRepository _musteriRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository;

        public MusteriService(IMusteriRepository musteriRepository,
            IKullaniciRepository kullaniciRepository,
            ILookupListRepository lookupListRepository)
        {
            _musteriRepository = musteriRepository;
            _kullaniciRepository = kullaniciRepository;
            _lookupListRepository = lookupListRepository;
        }

        public async Task<DataGridDto<MusteriListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<MusteriListDto>.Store((from a in _musteriRepository.All().Where(w => w.FirmaId == firmaid)
                                                                    join u in _kullaniciRepository.All() on a.KullaniciId equals u.Id
                                                                    join ilce in _lookupListRepository.All() on u.IlceId equals ilce.Id into ilcen
                                                                    from ilce in ilcen.DefaultIfEmpty()
                                                                    join il in _lookupListRepository.All() on ilce.ParentId equals il.Id into iln
                                                                    from il in iln.DefaultIfEmpty()
                                                                    select new MusteriListDto
                                                                    {
                                                                        Id = a.Id,
                                                                        Cinsiyet = a.CinsiyetErkek ? "Erkek" : "Kadın",
                                                                        Eposta = u.Eposta,
                                                                        Il = il.Isim,
                                                                        Ilce = ilce.Isim,
                                                                        Meslek = u.Unvan,
                                                                        Sirket = a.SirketAd,
                                                                        Telefon = u.Telefon,
                                                                        AdSoyad = u.AdSoyad,
                                                                        EvTelefon = a.EvTelefon,
                                                                        SirketAdres = a.SirketAdres,
                                                                        SirketArabasi = a.SirketAraci,
                                                                        SirketTelefon = a.SirketTelefon,
                                                                        TC = a.TC
                                                                    }
                    ));
        }

        public async Task<int> Save(Musteri model)
        {
            return await _musteriRepository.Save(model);
        }

        public async Task<bool> Update(Musteri model)
        {
            await _musteriRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await _musteriRepository.Delete(id, firmaid);
        }

        public async Task<Musteri> Get(int id, int firmaid)
        {
            return await _musteriRepository.All().Where(f => f.Id == id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}