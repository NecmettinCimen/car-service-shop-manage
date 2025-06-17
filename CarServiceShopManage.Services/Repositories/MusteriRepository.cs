using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;

namespace aracyonetim.services.Repositories
{
    public class MusteriRepository : GenericRepository<Musteri>, IMusteriRepository
    {
        public MusteriRepository(AracYonetimContext dbContext) : base(dbContext)
        {
        }
    }
}