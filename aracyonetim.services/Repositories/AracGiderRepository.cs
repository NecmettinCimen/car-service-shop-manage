using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class AracGiderRepository : GenericRepository<AracGider>, IAracGiderRepository
    {
        public AracGiderRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}