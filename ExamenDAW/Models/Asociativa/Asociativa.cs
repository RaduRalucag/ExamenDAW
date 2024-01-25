using ExamenDAW.Models.Base;

namespace ExamenDAW.Models.Asociativa
{
    public class Asociativa : BaseEntity
    {
        public ICollection<Participant.Participant> Participants { get; set; }

        public ICollection<Eveniment.Eveniment> Eveniments { get; set; }
    }
}
