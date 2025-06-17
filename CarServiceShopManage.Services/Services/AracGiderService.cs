using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface IAracGiderService
    {
        public Task<DataGridDto<AracGiderListDto>> List(int firmaid);
        public Task<int> Save(AracGider model);
        public Task<bool> Update(AracGider model);
        public Task Delete(int id, int firmaid);
        public Task<AracGider> Get(int id, int firmaid);
    }
    public class AracGiderService(
        IAracGiderRepository aracGiderRepository,
        IKullaniciRepository kullaniciRepository,
        IAracRepository aracRepository,
        ILookupListRepository lookupListRepository)
        : IAracGiderService
    {
        private readonly IKullaniciRepository _kullaniciRepository = kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository = lookupListRepository;

        public async Task<DataGridDto<AracGiderListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<AracGiderListDto>.Store((from a in aracGiderRepository.All().Where(w => w.FirmaId == firmaid)
                                                                      join arac in aracRepository.All() on a.AracId equals arac.Id
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
            return await aracGiderRepository.Save(model);
        }

        public async Task<bool> Update(AracGider model)
        {
            await aracGiderRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await aracGiderRepository.Delete(id, firmaid);
        }

        public async Task<AracGider> Get(int id, int firmaid)
        {
            return await aracGiderRepository.All().Where(f => f.Id == id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}