using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class FirmaRepository : GenericRepository<Firma>, IFirmaRepository
    {
        public FirmaRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}