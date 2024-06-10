using _final_BLL.DTO.Airplanes;
using _final_BLL.DTO.Pilots;
using _final_BLL.Services.Airplanes;
using _final_BLL.Services.GenericServices;
using _final_DAL.Models;
using _final_DAL.Repositries.Pilots;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.Pilots
{
    public class PilotService : GenericService<Pilot, PilotDTO>, IPilotService
    {
        private readonly IPilotRepository _pilotRepository;
        private readonly IMapper _mapper;

        public PilotService(IPilotRepository pilotRepository, IMapper mapper) : base(pilotRepository, mapper)
        {
            _pilotRepository = pilotRepository;
            _mapper = mapper;
        }
    }
}
