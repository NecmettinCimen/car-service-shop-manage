using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class AracHasarRepository(AracYonetimContext dbContext)
        : GenericRepository<AracHasar>(dbContext), IAracHasarRepository;
}