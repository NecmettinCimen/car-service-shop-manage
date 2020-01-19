using System.Linq;
using System.Threading.Tasks;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.services.Services
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
    public class KullaniciService:IKullaniciService
    {
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IRolRepository _rolRepository;

        public KullaniciService(IKullaniciRepository kullaniciRepository,
            IRolRepository rolRepository)
        {
            _kullaniciRepository = kullaniciRepository;
            _rolRepository = rolRepository;
        }
        public async Task<int> Save(Kullanici model)
        {
            return await _kullaniciRepository.Save(model);
        }
        public async Task Update(Kullanici model)
        {
            await _kullaniciRepository.Update(model);
        }

        public async Task<Kullanici> Login(string eposta, string parola)
        {
            return await  _kullaniciRepository
                .Find(f => f.Eposta == eposta && f.Parola == parola)
                .FirstOrDefaultAsync();
        }
        public async Task<Kullanici> Find(int id)
        {
            return await  _kullaniciRepository
                .Find(f => f.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task Delete(int id, int firmaid)
        {
            await _kullaniciRepository.Delete(id, firmaid);
        }

        public async Task<bool> EpostaCheck(string email)
        {
            return await _kullaniciRepository
                .All().AnyAsync(f => f.Eposta == email);
        }

        public async Task<DataGridDto<KullaniciListDto>> List(int firmaid)
        {
            return await GenerateDataGridDto<KullaniciListDto>.Store((from k in _kullaniciRepository.All(firmaid)
                    join i in _rolRepository.All() on k.RolId equals  i.Id
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