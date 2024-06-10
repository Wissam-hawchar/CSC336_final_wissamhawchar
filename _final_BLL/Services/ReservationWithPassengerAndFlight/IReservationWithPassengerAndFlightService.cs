using _final_BLL.DTO.Reservations;
using _final_BLL.Services.GenericServices;
using _final_BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.ReservationWithPassengerAndFlight
{
    public interface IReservationWithPassengerAndFlightService : IGenericService<ReservationWithPassengerAndFlightDTO>
    {
        APIResponse<ReservationWithPassengerAndFlightDTO> AddReservationWithPassengerAndFlight(ReservationWithPassengerAndFlightDTO dto);
    }
}
