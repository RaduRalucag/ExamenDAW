using AutoMapper;
using ExamenDAW.Services.EvenimenteService;
using Microsoft.AspNetCore.Mvc;
using ExamenDAW.Services.ParticipantService;
using ExamenDAW.Models.Participant.DTO;
using ExamenDAW.Models.Participant;

namespace ExamenDAW.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService, IMapper mapper)
        {
            _mapper = mapper;
            _participantService = participantService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParticipantResponseDto>>> GetParts()
        {
            var parts = await _participantService.GetAllParts();
            var partsResponseDtos = _mapper.Map<IEnumerable<ParticipantResponseDto>>(parts);
            return Ok(partsResponseDtos);
        }

        [HttpPost]
        public async Task<ActionResult<ParticipantResponseDto>> CreatePart([FromBody] ParticipantRequestDto participantRequestDto)
        {
            var part = _mapper.Map<Participant>(participantRequestDto);
            await _participantService.CreatePart(part);
            var participantResponseDto = _mapper.Map<ParticipantResponseDto>(part);
            return Ok(participantResponseDto);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ParticipantResponseDto>> GetPart(Guid id)
        {
            var part = await _participantService.GetPart(id);
            var participantResponseDto = _mapper.Map<ParticipantResponseDto>(part);
            return Ok(participantResponseDto);
        }
    }
}
