using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class Response
    {
        [Key]
        public int id { get; set; }
        public int serviceRequestId { get; set; }
        public string reportLink { get; set; }

        public ServiceRequest ServiceRequest { get; set; }
    }
}
