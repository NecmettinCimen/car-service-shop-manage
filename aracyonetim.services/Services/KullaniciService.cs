using System.Threading.Tasks;
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
    }
    public class KullaniciService:IKullaniciService
    {
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IMusteriRepository _musteriRepository;

        public KullaniciService(IKullaniciRepository kullaniciRepository,
            IMusteriRepository musteriRepository)
        {
            _kullaniciRepository = kullaniciRepository;
            _musteriRepository = musteriRepository;
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
    }
}