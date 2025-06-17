using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Services
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
    public class AracService(
        IAracRepository aracRepository,
        ILookupListRepository lookupListRepository,
        IKullaniciRepository kullaniciRepository)
        : IAracService
    {
        public async Task<DataGridDto<AracListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<AracListDto>.Store((from a in aracRepository.All().Where(w => w.FirmaId == firmaid)
                                                                 join m in lookupListRepository.All() on a.MarkaId equals m.Id into mn
                                                                 from m in mn.DefaultIfEmpty()
                                                                 join y in lookupListRepository.All() on a.YakitId equals y.Id into yn
                                                                 from y in yn.DefaultIfEmpty()
                                                                 join u in kullaniciRepository.All() on a.CreatorId equals u.Id
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
                aracRepository.All(firmaid).Select(s => new DxSelectDto { id = s.Id, text = s.Plaka, data = s }));
        }

        public async Task<int> Save(Arac model)
        {
            return await aracRepository.Save(model);
        }

        public async Task<bool> Update(Arac model)
        {
            await aracRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await aracRepository.Delete(id, firmaid);
        }

        public async Task<Arac> Get(int id, int firmaid)
        {
            return await aracRepository.Get(id, firmaid);
        }
    }
}