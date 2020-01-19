using System.Threading.Tasks;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.services.Services
{
    public interface IFirmaService
    {
        public Task<int> Save(Firma model);
        public Task Update(Firma model);
        public Task<Firma> Get(int id);
    }
    public class FirmaService:IFirmaService
    {
        private readonly IFirmaRepository _firmaRepository;

        public FirmaService(IFirmaRepository firmaRepository)
        {
            _firmaRepository = firmaRepository;
        }
        public async Task<int> Save(Firma model)
        {
            return await _firmaRepository.Save(model);
        }
        public async Task Update(Firma model)
        {
            await _firmaRepository.Update(model);
        }

        public async Task<Firma> Get(int id)
        {
            return await _firmaRepository.All().FirstAsync(f => f.Id == id);
        }
        
    }
}