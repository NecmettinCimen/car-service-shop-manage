using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface IAracOrtakService
    {
        public Task<DataGridDto<AracOrtakListDto>> List(int firmaid);
        public Task<int> Save(AracOrtak model);
        public Task<bool> Update(AracOrtak model);
        public Task Delete(int id, int firmaid);
        public Task<AracOrtak> Get(int id, int firmaid);
    }
    public class AracOrtakService(
        IAracOrtakRepository aracOrtakRepository,
        IKullaniciRepository kullaniciRepository,
        IAracRepository aracRepository,
        ILookupListRepository lookupListRepository)
        : IAracOrtakService
    {
        private readonly IKullaniciRepository _kullaniciRepository = kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository = lookupListRepository;

        public async Task<DataGridDto<AracOrtakListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<AracOrtakListDto>.Store((from a in aracOrtakRepository.All().Where(w => w.FirmaId == firmaid)
                                                                      join arac in aracRepository.All() on a.AracId equals arac.Id
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
            return await aracOrtakRepository.Save(model);
        }

        public async Task<bool> Update(AracOrtak model)
        {
            await aracOrtakRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await aracOrtakRepository.Delete(id, firmaid);
        }

        public async Task<AracOrtak> Get(int id, int firmaid)
        {
            return await aracOrtakRepository.All().Where(f => f.Id == id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}