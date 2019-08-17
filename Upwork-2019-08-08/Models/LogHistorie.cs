using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Upwork_2019_08_08.Models
{

    // "LogHistories" table from DB
    public class LogHistorie
    {
        [Key]
        public int id { get; set; }
        public int clientID { get; set; }
        public DateTime date { get; set; }
        public char logStatus { get; set; }

        public Client Client { get; set; }
    }
}
