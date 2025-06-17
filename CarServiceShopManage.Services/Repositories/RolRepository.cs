using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class RolRepository(AracYonetimContext dbContext) : GenericRepository<Rol>(dbContext), IRolRepository;
}