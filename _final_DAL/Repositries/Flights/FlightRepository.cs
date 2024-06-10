using _final_DAL.Models;
using _final_DAL.Repositries._GenericRepository;
using _final_DAL.Repositries.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_DAL.Repositries.Flights
{
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        public FlightRepository(AirplaneSystemContext umsContext) : base(umsContext)
        {
        }
    }
}
