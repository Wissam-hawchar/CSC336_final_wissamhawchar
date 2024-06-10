using _final_BLL.DTO.Reservations;
using _final_BLL.Services.GenericServices;
using _final_BLL.Services.Reservations;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReservationController : GenericController<ReservationDTO>
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService genericService) : base(genericService)
        {
            _reservationService = genericService;
        }
    }
}
