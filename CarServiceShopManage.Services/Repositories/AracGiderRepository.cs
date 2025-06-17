using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class AracGiderRepository(AracYonetimContext dbContext)
        : GenericRepository<AracGider>(dbContext), IAracGiderRepository;
}