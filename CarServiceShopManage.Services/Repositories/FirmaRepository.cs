using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class FirmaRepository(AracYonetimContext dbContext) : GenericRepository<Firma>(dbContext), IFirmaRepository;
}