using AutoMapper;
using ExamenDAW.Models.Eveniment;
using ExamenDAW.Models.Eveniment.DTO;
using ExamenDAW.Services.EvenimenteService;
using Microsoft.AspNetCore.Mvc;

namespace ExamenDAW.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EvenimentController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IEvenimentService _evenimentService;

        public EvenimentController(IEvenimentService evenimentService, IMapper mapper)
        {
            _mapper = mapper;
            _evenimentService = evenimentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvenimentResponseDto>>> GetEvents()
        {
            var events = await _evenimentService.GetAllEvents();
            var eventsResponseDtos = _mapper.Map<IEnumerable<EvenimentResponseDto>>(events);
            return Ok(eventsResponseDtos);
        }

        [HttpPost]
        public async Task<ActionResult<EvenimentResponseDto>> CreateEvent([FromBody]EvenimentRequestDto evenimentRequestDto)
        {
            var eveniment = _mapper.Map<Eveniment>(evenimentRequestDto);
            await _evenimentService.CreateEvent(eveniment);
            var evenimentResponseDto = _mapper.Map<EvenimentResponseDto>(eveniment);
            return Ok(evenimentResponseDto);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<EvenimentResponseDto>> GetEvent(Guid id)
        {
            var eveniment = await _evenimentService.GetEvent(id);
            var evenimentResponseDto = _mapper.Map<EvenimentResponseDto>(eveniment);
            return Ok(evenimentResponseDto);
        }
    }
}
