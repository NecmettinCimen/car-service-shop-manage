using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class AracHasarRepository : GenericRepository<AracHasar>, IAracHasarRepository
    {
        public AracHasarRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}