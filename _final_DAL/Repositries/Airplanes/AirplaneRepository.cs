using _final_DAL.Models;
using _final_DAL.Repositries._GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_DAL.Repositries.Airplanes
{
    public class AirplaneRepository : GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneSystemContext umsContext) : base(umsContext)
        {
        }
    }
}
