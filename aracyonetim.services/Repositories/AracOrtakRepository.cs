using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class AracOrtakRepository : GenericRepository<AracOrtak>, IAracOrtakRepository
    {
        public AracOrtakRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}