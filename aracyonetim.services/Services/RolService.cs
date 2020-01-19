using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aracyonetim.services.Services
{
    public interface IRolService
    {
        public Task<int> First();
        Task Save(Rol rol, string menuler);
        Task Update(Rol rol, string menuler);
        Task Delete(int id, int firmaid);
        Task<YetkilerSaveDto> Get(int id, int firmaid);
        Task<DataGridDto<Rol>> List(int firmaid);
        Task<DataGridDto<DxSelectDto>> Select(int firmaid);
        Task<List<Menu>> Menuler(int rolId);
        Task<int> MusteriRolId();
        Task<Rol> Find(int rolId, int rolFirmaId);
    }

    public class RolService : IRolService
    {
        private readonly IRolMenuRepository _rolMenuRepository;
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository,
            IRolMenuRepository rolMenuRepository)
        {
            _rolRepository = rolRepository;
            _rolMenuRepository = rolMenuRepository;
        }

        public async Task<int> First()
        {
            return await _rolRepository.All().OrderBy(o=>o.Id).Select(s => s.Id).FirstAsync();
        }

        public async Task Save(Rol rol, string menuler)
        {
            var rolid = await _rolRepository.Save(rol);
            foreach (var menuno in menuler.Split(","))
                await _rolMenuRepository.Save(new RolMenu
                    {CreatorId = rol.CreatorId, FirmaId = rol.FirmaId, MenuNo = int.Parse(menuno), RolId = rolid});
        }

        public async Task Update(Rol rol, string menuler)
        {
            await _rolRepository.Update(rol);

            var oldmenus = await _rolMenuRepository.All().Where(w => w.RolId == rol.Id).Select(s => s.Id).ToListAsync();
            foreach (var menu in oldmenus) await _rolMenuRepository.Delete(menu, rol.FirmaId.Value);

            foreach (var menuno in menuler.Split(","))
                await _rolMenuRepository.Save(new RolMenu
                    {CreatorId = rol.CreatorId, FirmaId = rol.FirmaId, MenuNo = int.Parse(menuno), RolId = rol.Id});
        }

        public async Task Delete(int id, int firmaid)
        {
            await _rolRepository.Delete(id, firmaid);
        }

        public async Task<YetkilerSaveDto> Get(int id, int firmaid)
        {
            var rol = await _rolRepository.Get(id, firmaid);
            var menus = await _rolMenuRepository.All().Where(w => w.RolId == id).Select(s => s.MenuNo).ToListAsync();
            return new YetkilerSaveDto
            {
                Id = id,
                Isim = rol.Isim,
                MenuList = MenuManager.MenuList.Where(s => menus.Contains(s.No)).Select(s=>new DxSelectDto
                {
                    id = s.No,
                    text = s.Isim
                }).ToList()
            };
        }

        public async Task<DataGridDto<Rol>> List(int firmaid)
        {
            return await GenerateDataGridDto<Rol>.Store(_rolRepository.All(firmaid));
        }

        public async Task<DataGridDto<DxSelectDto>> Select(int firmaid)
        {
            var result = await _rolRepository.All().Where(w => !w.FirmaId.HasValue).Select(s=>new DxSelectDto{id = s.Id,text = s.Isim}).ToListAsync();
            result.AddRange(await  _rolRepository.All(firmaid).Select(s=>new DxSelectDto{id = s.Id,text = s.Isim}).ToListAsync());
            return  new DataGridDto<DxSelectDto>
            {
                data = result
            };
        }

        public async Task<List<Menu>> Menuler(int rolId)
        {
            var menus = await _rolMenuRepository.All().Where(w => w.RolId == rolId).Select(s => s.MenuNo).ToListAsync();

            return MenuManager.MenuList.Where(s => menus.Contains(s.No)).ToList();
        }

        public async Task<int> MusteriRolId()
        {
            return await _rolRepository.All().Where(o=>o.Isim == "Müşteri").Select(s => s.Id).FirstAsync();
        }

        public async Task<Rol> Find(int rolId, int rolFirmaId)
        {
            return await _rolRepository.All(rolFirmaId).FirstAsync(f => f.Id == rolId);
        }
    }
}