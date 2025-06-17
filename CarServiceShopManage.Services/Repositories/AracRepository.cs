using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class AracRepository(AracYonetimContext dbContext) : GenericRepository<Arac>(dbContext), IAracRepository;
}