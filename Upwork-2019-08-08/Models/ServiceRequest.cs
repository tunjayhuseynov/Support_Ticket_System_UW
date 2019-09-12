using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class ServiceRequest
    {
        [Key]
        public int id { get; set; }
        public int clientUserId { get; set; }
        public int noOfIds { get; set; }
        public DateTime createdTime { get; set; }
        public char status { get; set; }

        public ClientUser ClientUser { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Response> Responses { get; set; }
    }
}
