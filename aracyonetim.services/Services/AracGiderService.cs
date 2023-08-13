using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace aracyonetim.services.Services
{
    public interface IAracGiderService
    {
        public Task<DataGridDto<AracGiderListDto>> List(int firmaid);
        public Task<int> Save(AracGider model);
        public Task<bool> Update(AracGider model);
        public Task Delete(int id, int firmaid);
        public Task<AracGider> Get(int id, int firmaid);
    }
    public class AracGiderService : IAracGiderService
    {
        private readonly IAracGiderRepository _aracGiderRepository;
        private readonly IAracRepository _aracRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository;

        public AracGiderService(IAracGiderRepository aracGiderRepository,
            IKullaniciRepository kullaniciRepository,
            IAracRepository aracRepository,
            ILookupListRepository lookupListRepository)
        {
            _aracGiderRepository = aracGiderRepository;
            _kullaniciRepository = kullaniciRepository;
            _lookupListRepository = lookupListRepository;
            _aracRepository = aracRepository;
        }

        public async Task<DataGridDto<AracGiderListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<AracGiderListDto>.Store((from a in _aracGiderRepository.All().Where(w => w.FirmaId == firmaid)
                                                                      join arac in _aracRepository.All() on a.AracId equals arac.Id
                                                                    select new AracGiderListDto
                                                                    {
                                                                        Id = a.Id,
                                                                        GiderTip = a.GiderTip,
                                                                        Fiyat = a.Fiyat,
                                                                        GiderTarih = a.GiderTarih,
                                                                        Aciklama = a.Aciklama,
                                                                        Plaka = arac.Plaka
                                                                    }
                    ));
        }

        public async Task<int> Save(AracGider model)
        {
            return await _aracGiderRepository.Save(model);
        }

        public async Task<bool> Update(AracGider model)
        {
            await _aracGiderRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await _aracGiderRepository.Delete(id, firmaid);
        }

        public async Task<AracGider> Get(int id, int firmaid)
        {
            return await _aracGiderRepository.All().Where(f => f.Id == id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}