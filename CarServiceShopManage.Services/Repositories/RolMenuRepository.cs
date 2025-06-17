using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class RolMenuRepository(AracYonetimContext dbContext)
        : GenericRepository<RolMenu>(dbContext), IRolMenuRepository;
}