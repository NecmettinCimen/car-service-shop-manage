using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class LookupListRepository : GenericRepository<LookupList>, ILookupListRepository
    {
        public LookupListRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}