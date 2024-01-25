using AutoMapper;
using ExamenDAW.Models.Eveniment;
using ExamenDAW.Models.Eveniment.DTO;
using ExamenDAW.Models.Participant;
using ExamenDAW.Models.Participant.DTO;

namespace ExamenDAW.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Eveniment, EvenimentResponseDto>();
            CreateMap<EvenimentRequestDto, Eveniment>();
            CreateMap<Participant, ParticipantResponseDto>();
            CreateMap<ParticipantRequestDto, Participant>();
        }
    }
}
