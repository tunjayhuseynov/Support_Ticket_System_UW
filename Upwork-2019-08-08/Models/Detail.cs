using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class Detail
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public string idNumber { get; set; }
        public int serviceTypeId { get; set; }
        public int serviceRequestId { get; set; }

        public ServiceType serviceType { get; set; }
        public ServiceRequest serviceRequest { get; set; }
    }
}
