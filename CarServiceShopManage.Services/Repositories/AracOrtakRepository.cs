using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class AracOrtakRepository(AracYonetimContext dbContext)
        : GenericRepository<AracOrtak>(dbContext), IAracOrtakRepository;
}