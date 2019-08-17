using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class Message
    {
        [Key]
        public int id { get; set; }
        public int ticketID { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string filename { get; set; }
        public DateTime datetime { get; set; }
        public bool from { get; set; }
        public int fromID { get; set; }

        [ForeignKey("ticketID")]
        public Ticket Ticket { get; set; }
    }
}
