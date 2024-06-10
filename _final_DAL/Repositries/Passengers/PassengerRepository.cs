using _final_DAL.Models;
using _final_DAL.Repositries._GenericRepository;
using _final_DAL.Repositries.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_DAL.Repositries.Passengers
{
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(AirplaneSystemContext umsContext) : base(umsContext)
        {
        }
    }
}
