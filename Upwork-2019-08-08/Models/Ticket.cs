using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{

    // "Tickets" table from DB
    public class Ticket
    {
        public int id { get; set; }
        public int clientID { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string filename { get; set; }
        public char status { get; set; }
        public DateTime datetime { get; set; }
       
        [ForeignKey("clientID")]
        public Client Client { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
