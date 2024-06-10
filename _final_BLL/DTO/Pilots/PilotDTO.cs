using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _final_BLL.DTO.Pilots
{
    public class PilotDTO
    {
        public int PilotId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? LicenseNumber { get; set; }

        public DateOnly? CertificationDate { get; set; }
    }
}
