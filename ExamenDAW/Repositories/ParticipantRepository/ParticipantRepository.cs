using ExamenDAW.Data;
using ExamenDAW.Models.Participant;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.ParticipantRepository
{
    public class ParticipantRepository : GenericRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
