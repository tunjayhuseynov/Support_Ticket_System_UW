using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Upwork_2019_08_08.Models
{
    // "Feedbacks" table from DB
    public class Feedback
    {
        [Key]
        public int id { get; set; }

        public  int clientID { get; set; }

        [Column("datetime")]
        public DateTime datetime { get; set; }
        public string message { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string cellPhone { get; set; }
        public Client Client { get; set; }

    }
}
