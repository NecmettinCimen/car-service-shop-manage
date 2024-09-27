using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace aracyonetim.services.Services
{
    public interface IAracOrtakService
    {
        public Task<DataGridDto<AracOrtakListDto>> List(int firmaid);
        public Task<int> Save(AracOrtak model);
        public Task<bool> Update(AracOrtak model);
        public Task Delete(int id, int firmaid);
        public Task<AracOrtak> Get(int id, int firmaid);
    }
    public class AracOrtakService : IAracOrtakService
    {
        private readonly IAracOrtakRepository _aracOrtakRepository;
        private readonly IAracRepository _aracRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository;

        public AracOrtakService(IAracOrtakRepository aracOrtakRepository,
            IKullaniciRepository kullaniciRepository,
            IAracRepository aracRepository,
            ILookupListRepository lookupListRepository)
        {
            _aracOrtakRepository = aracOrtakRepository;
            _kullaniciRepository = kullaniciRepository;
            _lookupListRepository = lookupListRepository;
            _aracRepository = aracRepository;
        }

        public async Task<DataGridDto<AracOrtakListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<AracOrtakListDto>.Store((from a in _aracOrtakRepository.All().Where(w => w.FirmaId == firmaid)
                                                                      join arac in _aracRepository.All() on a.AracId equals arac.Id
                                                                    select new AracOrtakListDto
                                                                    {
                                                                        Id = a.Id,
                                                                        OrtakAdi = a.OrtakAdi,
                                                                        Oran = a.Oran,
                                                                        Fiyat = a.Fiyat,
                                                                        Plaka = arac.Plaka
                                                                    }
                    ));
        }

        public async Task<int> Save(AracOrtak model)
        {
            return await _aracOrtakRepository.Save(model);
        }

        public async Task<bool> Update(AracOrtak model)
        {
            await _aracOrtakRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await _aracOrtakRepository.Delete(id, firmaid);
        }

        public async Task<AracOrtak> Get(int id, int firmaid)
        {
            return await _aracOrtakRepository.All().Where(f => f.Id == id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}