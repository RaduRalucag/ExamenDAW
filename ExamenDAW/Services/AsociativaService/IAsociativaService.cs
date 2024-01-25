using ExamenDAW.Models.Asociativa;
using ExamenDAW.Models.Participant;

namespace ExamenDAW.Services.AsociativaService
{
    public interface IAsociativaService
    {
        Task CreateAllAsocs(IList<Asociativa> Asocs);
        Task CreateAsoc(Asociativa Asocs);
        Task<IEnumerable<Asociativa>> GetAllAsocs();
        Task<Asociativa> GetAsoc(Guid id);
    }
}
