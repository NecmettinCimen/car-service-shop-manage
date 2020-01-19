using aracyonetim.database;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class ChartDtoRepository : GenericRepository<ChartDto>, IChartDtoRepository
    {
        public ChartDtoRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}