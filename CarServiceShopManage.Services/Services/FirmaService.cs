using System.Threading.Tasks;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface IFirmaService
    {
        public Task<int> Save(Firma model);
        public Task Update(Firma model);
        public Task<Firma> Get(int id);
    }
    public class FirmaService(IFirmaRepository firmaRepository) : IFirmaService
    {
        public async Task<int> Save(Firma model)
        {
            return await firmaRepository.Save(model);
        }
        public async Task Update(Firma model)
        {
            await firmaRepository.Update(model);
        }

        public async Task<Firma> Get(int id)
        {
            return await firmaRepository.All().FirstAsync(f => f.Id == id);
        }

    }
}