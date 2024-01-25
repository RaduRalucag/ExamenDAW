using ExamenDAW.Models.Base;

namespace ExamenDAW.Models.Participant
{
    public class Participant : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Guid AsociativaId { get; set; }
        public Asociativa.Asociativa Asociativa { get; set; }
    }
}
