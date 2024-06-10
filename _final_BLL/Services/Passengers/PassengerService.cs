using _final_BLL.DTO.Airplanes;
using _final_BLL.DTO.Passengers;
using _final_BLL.Services.Airplanes;
using _final_BLL.Services.GenericServices;
using _final_DAL.Models;
using _final_DAL.Repositries.Passengers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.Passengers
{
    public class PassengerService : GenericService<Passenger, PassengerDTO>, IPassengerService
    {
        private readonly IPassengerRepository _passengerRepository;
        private readonly IMapper _mapper;

        public PassengerService(IPassengerRepository passengerRepository, IMapper mapper) : base(passengerRepository, mapper)
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }
    }
}
