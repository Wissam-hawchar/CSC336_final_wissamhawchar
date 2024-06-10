using _final_BLL.DTO.Pilots;
using _final_BLL.Services.GenericServices;
using _final_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PilotController : GenericController<PilotDTO>
    {
        private readonly IPilotService _pilotService;

        public PilotController(IPilotService genericService) : base(genericService)
        {
            _pilotService = genericService;
        }
    }
}
