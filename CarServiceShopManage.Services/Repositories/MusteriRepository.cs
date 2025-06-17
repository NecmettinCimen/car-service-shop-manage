using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class MusteriRepository(AracYonetimContext dbContext)
        : GenericRepository<Musteri>(dbContext), IMusteriRepository;
}