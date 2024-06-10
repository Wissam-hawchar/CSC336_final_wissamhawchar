using _final_BLL.DTO.Flights;
using _final_BLL.DTO.Passengers;
using _final_BLL.DTO.Reservations;
using _final_BLL.Services.GenericServices;
using _final_BLL.Services.Reservations;
using _final_BLL.Wrapping;
using _final_DAL.Models;
using _final_DAL.Repositries.Flights;
using _final_DAL.Repositries.Passengers;
using _final_DAL.Repositries.Reservations;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _final_BLL.Services.ReservationWithPassengerAndFlight
{
    using Entity = _final_DAL.Models.Reservation;
    using Dto = _final_BLL.DTO.Reservations.ReservationWithPassengerAndFlightDTO;
    public class ReservationWithPassengerAndFlightService : GenericService<Entity, Dto>, IReservationWithPassengerAndFlightService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IPassengerRepository _passengerRepository;
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public ReservationWithPassengerAndFlightService(IReservationRepository reservationRepository, IPassengerRepository passengerRepository, IFlightRepository flightRepository, IMapper mapper) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _passengerRepository = passengerRepository;
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public APIResponse<Dto> AddReservationWithPassengerAndFlight(Dto dto)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var passenger = _mapper.Map<Passenger>(dto.PassengerDTO);
                    if (passenger == null)
                    {
                        throw new Exception("Null");
                    }
                    var passengerResult = _passengerRepository.Add(passenger);
                    var passengerItemDto = _mapper.Map<PassengerDTO>(passengerResult);

                    var flight = _mapper.Map<Flight>(dto.FlightDTO);
                    if (flight == null)
                    {
                        throw new Exception("Null");
                    }
                    var flightResult = _flightRepository.Add(flight);
                    var flightItemDto = _mapper.Map<FlightDTO>(flightResult);

                    var response = new APIResponse<Dto>();
                    var entity = _mapper.Map<Entity>(dto);
                    entity.PassengerId=passengerItemDto.PassengerId;
                    entity.FlightId=flightItemDto.FlightId;
                    if (entity == null)
                    {
                        throw new Exception("Null");
                    }
                    var result = _reservationRepository.Add(entity);
                    response.Data = _mapper.Map<Dto>(result);
                    return response;
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    var response = new APIResponse<Dto>()
                    {
                        Success = false,
                        ErrorMessage = ex.Message
                    };
                    return response;
                }
            }
        }
    }
}
