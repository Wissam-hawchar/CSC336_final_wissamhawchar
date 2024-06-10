using _final_BLL.DTO.Flights;
using _final_BLL.Services.Flights;
using _final_BLL.Services.GenericServices;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FlightController : GenericController<FlightDTO>
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService genericService) : base(genericService)
        {
            _flightService = genericService;
        }
    }
}
