using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class RolMenuRepository : GenericRepository<RolMenu>, IRolMenuRepository
    {
        public RolMenuRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}