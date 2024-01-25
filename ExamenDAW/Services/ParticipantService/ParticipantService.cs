using ExamenDAW.Models.Eveniment;
using ExamenDAW.Models.Participant;
using ExamenDAW.Repositories.EvenimentRepository;
using ExamenDAW.Repositories.ParticipantRepository;
using ExamenDAW.Services.EvenimenteService;

namespace ExamenDAW.Services.ParticipantService
{
    public class ParticipantService : IParticipantService
    {

            private readonly IParticipantRepository _participantRepository;

            public ParticipantService(IParticipantRepository repository)
            {
                _participantRepository = repository;
            }

            public async Task<IEnumerable<Participant>> GetAllParts()
        {
                return await _participantRepository.GetAllAsync();
            }

            public async Task CreatePart(Participant participant)
            {
                await _participantRepository.CreateAsync(participant);
                await _participantRepository.SaveAsync();
            }

            public async Task<Participant> GetPart(Guid id)
            {
                return await _participantRepository.FindByIdAsync(id);
            }

            public async Task CreateAllParts(IList<Participant> participants)
            {
                foreach (var participant in participants)
                {
                    await _participantRepository.CreateAsync(participant);
                }
                await _participantRepository.SaveAsync();
            }
    }
}
