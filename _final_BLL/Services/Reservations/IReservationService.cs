using _final_BLL.DTO.Airplanes;
using _final_BLL.DTO.Reservations;
using _final_BLL.Services.GenericServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.Reservations
{
    public interface IReservationService : IGenericService<ReservationDTO>
    {
    }
}
