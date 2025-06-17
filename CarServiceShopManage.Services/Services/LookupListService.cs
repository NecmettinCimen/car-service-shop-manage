using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
{
    public interface ILookupListService
    {
        public Task<DataGridDto<DxSelectDto>> List(Lookup model);
        public Task<DataGridDto<DxSelectDto>> List(Lookup model, int parentId);
        public Task<int> First(Lookup model);
        Task<int> GetParentId(int ilceid);
    }

    public class LookupListService(ILookupListRepository lookupListRepository) : ILookupListService
    {
        public async Task<DataGridDto<DxSelectDto>> List(Lookup model)
        {
            return await GenerateDataGridDto<DxSelectDto>.Store(lookupListRepository.All()
                .Where(w => w.Tip == model)
                .Select(s => new DxSelectDto
                {
                    id = s.Id,
                    text = s.Isim
                }).OrderBy(o => o.text), "id");
        }
        public async Task<DataGridDto<DxSelectDto>> List(Lookup model, int id)
        {
            return await GenerateDataGridDto<DxSelectDto>.Store(lookupListRepository.All()
                .Where(w => w.Tip == model && w.ParentId == id)
                .Select(s => new DxSelectDto
                {
                    id = s.Id,
                    text = s.Isim
                }).OrderBy(o => o.text), "id");
        }
        public async Task<int> First(Lookup model)
        {
            return await lookupListRepository.All()
                .Where(w => w.Tip == model)
                .OrderBy(o => o.Id)
                .Select(s => s.Id).FirstAsync();
        }

        public async Task<int> GetParentId(int ilceid)
        {
            return await lookupListRepository.Find(f => f.Id == ilceid).Select(s => s.ParentId.Value).FirstAsync();
        }
    }
}