using _final_BLL.DTO.Airplanes;
using _final_BLL.Services.GenericServices;
using _final_DAL.Models;
using _final_DAL.Repositries.Airplanes;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.Services.Airplanes
{
    public class AirplaneService : GenericService<Airplane, AirplaneDTO>, IAirplaneService
    {
        private readonly IAirplaneRepository _airplaneRepository;
        private readonly IMapper _mapper;

        public AirplaneService(IAirplaneRepository airplaneRepository, IMapper mapper) : base(airplaneRepository, mapper)
        {
            _airplaneRepository = airplaneRepository;
            _mapper = mapper;
        }
    }
}
