using System;
using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface IAracHasarService
    {
        public Task<DataGridDto<AracHasarListDto>> List(int firmaid);
        public Task<int> Save(AracHasar model);
        public Task<bool> Update(AracHasar model);
        public Task Delete(int id, int firmaid);
        public Task<AracHasar> Get(int id, int firmaid);
    }
    public class AracHasarService(
        IAracHasarRepository aracHasarRepository,
        IKullaniciRepository kullaniciRepository,
        IAracRepository aracRepository,
        ILookupListRepository lookupListRepository)
        : IAracHasarService
    {
        private readonly IKullaniciRepository _kullaniciRepository = kullaniciRepository;
        private readonly ILookupListRepository _lookupListRepository = lookupListRepository;

        public async Task<DataGridDto<AracHasarListDto>> List(int firmaid)
        {
            var list = await GenerateDataGridDto<AracHasarListDto>.Store((from a in aracHasarRepository.All().Where(w => w.FirmaId == firmaid)
                                                                      join arac in aracRepository.All() on a.AracId equals arac.Id
                                                                      select new AracHasarListDto
                                                                      {
                                                                          Id = a.Id,
                                                                          Plaka = arac.Plaka,
                                                                          AracHasar = a,
                                                                      }
                    ));

            foreach ( var a in list.data)
            {
                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SagArkaCamurluk.ToString(), out var SagArkaCamurluk);
                a.SagArkaCamurluk = SagArkaCamurluk.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.ArkaKaput.ToString(), out var ArkaKaput);
                a.ArkaKaput = ArkaKaput.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SolArkaCamurluk.ToString(), out var SolArkaCamurluk);
                a.SolArkaCamurluk = SolArkaCamurluk.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SagArkaKapi.ToString(), out var SagArkaKapi);
                a.SagArkaKapi = SagArkaKapi.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SagOnKapi.ToString(), out var SagOnKapi);
                a.SagOnKapi = SagOnKapi.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.Tavan.ToString(), out var Tavan);
                a.Tavan = Tavan.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SolOnKapi.ToString(), out var SolOnKapi);
                a.SolOnKapi = SolOnKapi.ToString();
                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SagOnCamurluk.ToString(), out var SagOnCamurluk);
                a.SagOnCamurluk = SagOnCamurluk.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.MotorKaputu.ToString(), out var MotorKaputu);
                a.MotorKaputu = MotorKaputu.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SolOnCamurluk.ToString(), out var SolOnCamurluk);
                a.SolOnCamurluk = SolOnCamurluk.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.OnTampon.ToString(), out var OnTampon);
                a.OnTampon = OnTampon.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.ArkaTampon.ToString(), out var ArkaTampon);
                a.ArkaTampon = ArkaTampon.ToString();

                Enum.TryParse(typeof(EAracHasar), a.AracHasar.SolArkaKapi.ToString(), out var SolArkaKapi);
                a.SolArkaKapi = SolArkaKapi.ToString();

            }

            return list;
        }

        public async Task<int> Save(AracHasar model)
        {
            return await aracHasarRepository.Save(model);
        }

        public async Task<bool> Update(AracHasar model)
        {
            await aracHasarRepository.Update(model);
            return true;
        }

        public async Task Delete(int id, int firmaid)
        {
            await aracHasarRepository.Delete(id, firmaid);
        }

        public async Task<AracHasar> Get(int id, int firmaid)
        {
            return await aracHasarRepository.All().Where(f => f.Id == id && f.FirmaId == firmaid).FirstAsync();
        }
    }
}