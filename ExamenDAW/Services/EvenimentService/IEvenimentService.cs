using ExamenDAW.Models.Eveniment;

namespace ExamenDAW.Services.EvenimenteService
{
    public interface IEvenimentService
    {
        Task CreateAllEvents(IList<Eveniment> Events);
        Task CreateEvent(Eveniment Event);
        Task<IEnumerable<Eveniment>> GetAllEvents();
        Task<Eveniment> GetEvent(Guid id);
    }
}
