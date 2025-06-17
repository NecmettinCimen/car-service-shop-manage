using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface IKullaniciService
    {
        public Task<int> Save(Kullanici model);
        public Task Update(Kullanici model);
        public Task<Kullanici> Login(string eposta, string parola);
        public Task<Kullanici> Find(int id);
        public Task Delete(int id, int firmaid);
        public Task<bool> EpostaCheck(string eposta);
        public Task<DataGridDto<KullaniciListDto>> List(int firmaid);
    }
    public class KullaniciService(
        IKullaniciRepository kullaniciRepository,
        IRolRepository rolRepository)
        : IKullaniciService
    {
        public async Task<int> Save(Kullanici model)
        {
            // Parolayı şifrele
            model.Parola = PasswordHelper.HashPassword(model.Parola);
            return await kullaniciRepository.Save(model);
        }
        public async Task Update(Kullanici model)
        {
            // Eğer parola değiştirilmişse şifrele
            var existingUser = await kullaniciRepository.Find(f => f.Id == model.Id).FirstOrDefaultAsync();
            if (existingUser != null && existingUser.Parola != model.Parola)
            {
                model.Parola = PasswordHelper.HashPassword(model.Parola);
            }
            await kullaniciRepository.Update(model);
        }

        public async Task<Kullanici> Login(string eposta, string parola)
        {
            var kullanici = await kullaniciRepository
                .Find(f => f.Eposta == eposta)
                .FirstOrDefaultAsync();
            
            if (kullanici != null && PasswordHelper.VerifyPassword(parola, kullanici.Parola))
            {
                return kullanici;
            }
            
            return null;
        }
        public async Task<Kullanici> Find(int id)
        {
            return await kullaniciRepository
                .Find(f => f.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task Delete(int id, int firmaid)
        {
            await kullaniciRepository.Delete(id, firmaid);
        }

        public async Task<bool> EpostaCheck(string email)
        {
            return await kullaniciRepository
                .All().AnyAsync(f => f.Eposta == email);
        }

        public async Task<DataGridDto<KullaniciListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<KullaniciListDto>.Store((from k in kullaniciRepository.All(firmaid)
                                                                      join i in rolRepository.All() on k.RolId equals i.Id
                                                                      select new KullaniciListDto
                                                                      {
                                                                          Adres = k.Adres,
                                                                          Eposta = k.Eposta,
                                                                          Id = k.Id,
                                                                          Meslek = k.Unvan,
                                                                          Rol = i.Isim,
                                                                          Telefon = k.Telefon,
                                                                          AdSoyad = k.AdSoyad
                                                                      }));
        }
    }
}