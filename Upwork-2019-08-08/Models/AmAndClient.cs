using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{

    // Get Relations between Account Manager and Clients from DB
    public class AmAndClient
    {
        [Key]
        public int id { get; set; }
        public int clientID { get; set; }
        public int amID { get; set; }
        public DateTime assignedTime { get; set; }

        public Client Client { get; set; }
        public Admin Admin { get; set; }
    }
}
