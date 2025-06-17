using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarServiceShopManage.Services.Services
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

    public class RolService(
        IRolRepository rolRepository,
        IRolMenuRepository rolMenuRepository)
        : IRolService
    {
        public async Task<int> First()
        {
            return await rolRepository.All().OrderBy(o => o.Id).Select(s => s.Id).FirstAsync();
        }

        public async Task Save(Rol rol, string menuler)
        {
            var rolid = await rolRepository.Save(rol);
            foreach (var menuno in menuler.Split(","))
                await rolMenuRepository.Save(new RolMenu
                { CreatorId = rol.CreatorId, FirmaId = rol.FirmaId, MenuNo = int.Parse(menuno), RolId = rolid });
        }

        public async Task Update(Rol rol, string menuler)
        {
            await rolRepository.Update(rol);

            var oldmenus = await rolMenuRepository.All().Where(w => w.RolId == rol.Id).Select(s => s.Id).ToListAsync();
            foreach (var menu in oldmenus) await rolMenuRepository.Delete(menu, rol.FirmaId.Value);

            foreach (var menuno in menuler.Split(","))
                await rolMenuRepository.Save(new RolMenu
                { CreatorId = rol.CreatorId, FirmaId = rol.FirmaId, MenuNo = int.Parse(menuno), RolId = rol.Id });
        }

        public async Task Delete(int id, int firmaid)
        {
            await rolRepository.Delete(id, firmaid);
        }

        public async Task<YetkilerSaveDto> Get(int id, int firmaid)
        {
            var rol = await rolRepository.Get(id, firmaid);
            var menus = await rolMenuRepository.All().Where(w => w.RolId == id).Select(s => s.MenuNo).ToListAsync();
            return new YetkilerSaveDto
            {
                Id = id,
                Isim = rol.Isim,
                MenuList = MenuManager.MenuList.Where(s => menus.Contains(s.No)).Select(s => new DxSelectDto
                {
                    id = s.No,
                    text = s.Isim
                }).ToList()
            };
        }

        public async Task<DataGridDto<Rol>> List(int firmaid)
        {
            return await GenerateDataGridDto<Rol>.Store(rolRepository.All(firmaid));
        }

        public async Task<DataGridDto<DxSelectDto>> Select(int firmaid)
        {
            var result = await rolRepository.All().Where(w => !w.FirmaId.HasValue).Select(s => new DxSelectDto { id = s.Id, text = s.Isim }).ToListAsync();
            result.AddRange(await rolRepository.All(firmaid).Select(s => new DxSelectDto { id = s.Id, text = s.Isim }).ToListAsync());
            return new DataGridDto<DxSelectDto>
            {
                data = result
            };
        }

        public async Task<List<Menu>> Menuler(int rolId)
        {
            var menus = await rolMenuRepository.All().Where(w => w.RolId == rolId).Select(s => s.MenuNo).ToListAsync();

            return MenuManager.MenuList.Where(s => menus.Contains(s.No)).ToList();
        }

        public async Task<int> MusteriRolId()
        {
            return await rolRepository.All().Where(o => o.Isim == "Müşteri").Select(s => s.Id).FirstAsync();
        }

        public async Task<Rol> Find(int rolId, int rolFirmaId)
        {
            return await rolRepository.All(rolFirmaId).FirstAsync(f => f.Id == rolId);
        }
    }
}