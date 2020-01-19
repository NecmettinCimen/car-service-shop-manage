using System.Linq;
using System.Threading.Tasks;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.services.Services
{
    public interface ILookupListService
    {
        public Task<DataGridDto<DxSelectDto>> List(Lookup model);
        public Task<DataGridDto<DxSelectDto>> List(Lookup model, int parentId);
        public Task<int> First(Lookup model);
        Task<int> GetParentId(int ilceid);
    }

    public class LookupListService : ILookupListService
    {
        private readonly ILookupListRepository _lookupListRepository;

        public LookupListService(ILookupListRepository lookupListRepository)
        {
            _lookupListRepository = lookupListRepository;
        }

        public async Task<DataGridDto<DxSelectDto>> List(Lookup model)
        {
            return await GenerateDataGridDto<DxSelectDto>.Store(_lookupListRepository.All()
                .Where(w => w.Tip == model)
                .Select(s => new DxSelectDto
                {
                    id = s.Id,
                    text = s.Isim
                }).OrderBy(o=>o.text), "id");
        }
        public async Task<DataGridDto<DxSelectDto>> List(Lookup model, int id)
        {
            return await GenerateDataGridDto<DxSelectDto>.Store(_lookupListRepository.All()
                .Where(w => w.Tip == model && w.ParentId==id)
                .Select(s => new DxSelectDto
                {
                    id = s.Id,
                    text = s.Isim
                }).OrderBy(o=>o.text), "id");
        }
        public async Task<int> First(Lookup model)
        {
            return await _lookupListRepository.All()
                .Where(w => w.Tip == model)
                .OrderBy(o=>o.Id)
                .Select(s => s.Id).FirstAsync();
        }

        public async Task<int> GetParentId(int ilceid)
        {
            return await _lookupListRepository.Find(f => f.Id == ilceid).Select(s => s.ParentId.Value).FirstAsync();
        }
    }
}