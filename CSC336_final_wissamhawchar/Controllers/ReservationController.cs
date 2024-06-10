using _final_BLL.DTO.Reservations;
using _final_BLL.Services.GenericServices;
using _final_BLL.Services.Reservations;
using _final_BLL.Services.ReservationWithPassengerAndFlight;
using _final_BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReservationController : GenericController<ReservationDTO>
    {
        private readonly IReservationService _reservationService;
        private readonly IReservationWithPassengerAndFlightService _reservationWithPassengerAndFlightService;

        public ReservationController(IReservationService genericService) : base(genericService)
        {
            _reservationService = genericService;

        }

        [HttpPost("AddReservationWithPassengerAndFlight")]
        public APIResponse<ReservationWithPassengerAndFlightDTO> AddReservationWithPassengerAndFlight(ReservationWithPassengerAndFlightDTO dto)
        {
            return _reservationWithPassengerAndFlightService.AddReservationWithPassengerAndFlight(dto);
        }
    }
}
