using CarServiceShopManage.Database;
using CarServiceShopManage.Entities.Dtos;
using CarServiceShopManage.Services.Interfaces;

namespace CarServiceShopManage.Services.Repositories
{
    public class ChartDtoRepository(AracYonetimContext dbContext)
        : GenericRepository<ChartDto>(dbContext), IChartDtoRepository;
}