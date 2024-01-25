using ExamenDAW.Models.Asociativa;
using ExamenDAW.Models.Participant;
using ExamenDAW.Repositories.AsociativaRepository;
using ExamenDAW.Repositories.ParticipantRepository;

namespace ExamenDAW.Services.AsociativaService
{
    public class AsociativaService : IAsociativaService
    {
        private readonly IAsociativaRepository _asociativaRepository;

        public AsociativaService(IAsociativaRepository repository)
        {
            _asociativaRepository = repository;
        }

        public async Task<IEnumerable<Asociativa>> GetAllAsocs()
        {
            return await _asociativaRepository.GetAllAsync();
        }

        public async Task CreateAsoc(Asociativa asociativa)
        {
            await _asociativaRepository.CreateAsync(asociativa);
            await _asociativaRepository.SaveAsync();
        }

        public async Task<Asociativa> GetAsoc(Guid id)
        {
            return await _asociativaRepository.FindByIdAsync(id);
        }

        public async Task CreateAllAsocs(IList<Asociativa> asociativas)
        {
            foreach (var asociativa in asociativas)
            {
                await _asociativaRepository.CreateAsync(asociativa);
            }
            await _asociativaRepository.SaveAsync();
        }
    }
}
