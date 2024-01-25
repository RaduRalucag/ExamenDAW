using ExamenDAW.Models.Eveniment;
using ExamenDAW.Models.Participant;

namespace ExamenDAW.Services.ParticipantService
{
    public interface IParticipantService
    {
        Task CreateAllParts(IList<Participant> Parts);
        Task CreatePart(Participant Part);
        Task<IEnumerable<Participant>> GetAllParts();
        Task<Participant> GetPart(Guid id);
    }
}
