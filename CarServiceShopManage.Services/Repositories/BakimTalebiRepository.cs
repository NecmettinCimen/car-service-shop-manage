using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class BakimTalebiRepository : GenericRepository<BakimTalebi>, IBakimTalebiRepository
    {
        public BakimTalebiRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}