using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class KullaniciRepository(AracYonetimContext dbContext)
        : GenericRepository<Kullanici>(dbContext), IKullaniciRepository;
}