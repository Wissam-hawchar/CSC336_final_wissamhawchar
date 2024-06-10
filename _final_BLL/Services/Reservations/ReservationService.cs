using _final_BLL.DTO.Airplanes;
using _final_BLL.DTO.Reservations;
using _final_BLL.Services.Airplanes;
using _final_BLL.Services.GenericServices;
using _final_DAL.Models;
using _final_DAL.Repositries.Reservations;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.Reservations
{
    public class ReservationService : GenericService<Reservation, ReservationDTO>, IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
    }
}
