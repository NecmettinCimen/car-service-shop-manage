using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class LookupListRepository(AracYonetimContext dbContext)
        : GenericRepository<LookupList>(dbContext), ILookupListRepository;
}