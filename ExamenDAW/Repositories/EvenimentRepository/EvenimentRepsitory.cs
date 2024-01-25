using ExamenDAW.Data;
using ExamenDAW.Models.Eveniment;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.EvenimentRepository
{
    public class EvenimentRepsitory : GenericRepository<Eveniment>, IEvenimentRepository
    {
        public EvenimentRepsitory(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
