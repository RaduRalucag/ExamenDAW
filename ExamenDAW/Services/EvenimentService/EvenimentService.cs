using ExamenDAW.Models.Eveniment;
using ExamenDAW.Repositories.EvenimentRepository;

namespace ExamenDAW.Services.EvenimenteService
{
    public class EvenimentService : IEvenimentService
    {

        private readonly IEvenimentRepository _evenimentRepository;

        public EvenimentService(IEvenimentRepository repository)
        {
            _evenimentRepository = repository;
        }

        public async Task<IEnumerable<Eveniment>> GetAllEvents()
        {
            return await _evenimentRepository.GetAllAsync();
        }

        public async Task CreateEvent(Eveniment eveniment)
        {
            await _evenimentRepository.CreateAsync(eveniment);
            await _evenimentRepository.SaveAsync();
        }

        public async Task<Eveniment> GetEvent(Guid id)
        {
            return await _evenimentRepository.FindByIdAsync(id);
        }

        public async Task CreateAllEvents(IList<Eveniment> eveniments)
        {
            foreach (var eveniment in eveniments)
            {
                await _evenimentRepository.CreateAsync(eveniment);
            }
            await _evenimentRepository.SaveAsync();
        }
    }
}
