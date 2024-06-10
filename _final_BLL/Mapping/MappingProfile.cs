using _final_BLL.DTO.Airplanes;
using _final_BLL.DTO.Flights;
using _final_BLL.DTO.Passengers;
using _final_BLL.DTO.Pilots;
using _final_BLL.DTO.Reservations;
using _final_DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Airplane, AirplaneDTO>().ReverseMap();
            CreateMap<Flight, FlightDTO>().ReverseMap();
            CreateMap<Passenger, PassengerDTO>().ReverseMap();
            CreateMap<Pilot, PilotDTO>().ReverseMap();
            CreateMap<Reservation, ReservationDTO>().ReverseMap();
            CreateMap<Reservation, ReservationWithPassengerAndFlightDTO>().ReverseMap();
        }
    }
}
