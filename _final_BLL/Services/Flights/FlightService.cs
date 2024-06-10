using _final_BLL.DTO.Airplanes;
using _final_BLL.DTO.Flights;
using _final_BLL.Services.Airplanes;
using _final_BLL.Services.GenericServices;
using _final_DAL.Models;
using _final_DAL.Repositries.Flights;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.Flights
{
    public class FlightService : GenericService<Flight, FlightDTO>, IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public FlightService(IFlightRepository flightRepository, IMapper mapper) : base(flightRepository, mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }
    }
}
