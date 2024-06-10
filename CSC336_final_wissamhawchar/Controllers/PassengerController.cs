using _final_BLL.DTO.Passengers;
using _final_BLL.Services.Passengers;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PassengerController : GenericController<PassengerDTO>
    {
        private readonly IPassengerService _passengerService;

        public PassengerController(IPassengerService genericService) : base(genericService)
        {
            _passengerService = genericService;
        }
    }
}
