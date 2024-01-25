using ExamenDAW.Models.Base;

namespace ExamenDAW.Models.Eveniment
{
    public class Eveniment : BaseEntity
    {
        public string Nume { get; set; }
        public string Data { get; set; }
        public Guid AsociativaId { get; set; }
       public Asociativa.Asociativa Asociativa { get; set; }
    }
}
