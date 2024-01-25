using ExamenDAW.Data;
using ExamenDAW.Models.Asociativa;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.AsociativaRepository
{
    public class AsociativaRepository : GenericRepository<Asociativa>, IAsociativaRepository
    {
        public AsociativaRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
