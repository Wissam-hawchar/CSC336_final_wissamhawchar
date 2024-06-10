using _final_BLL.DTO.Airplanes;
using _final_BLL.Services.Airplanes;
using _final_BLL.Services.GenericServices;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AirplaneController : GenericController<AirplaneDTO>
    {
        private readonly IAirplaneService _airplaneService;

        public AirplaneController(IAirplaneService genericService) : base(genericService)
        {
            _airplaneService = genericService;
        }
    }
}
