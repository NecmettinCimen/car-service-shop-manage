using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Tables;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class BakimTalebiRepository(AracYonetimContext dbContext)
        : GenericRepository<BakimTalebi>(dbContext), IBakimTalebiRepository;
}