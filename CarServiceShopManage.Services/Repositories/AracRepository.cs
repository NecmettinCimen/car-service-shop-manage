using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class AracRepository : GenericRepository<Arac>, IAracRepository
    {
        public AracRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}