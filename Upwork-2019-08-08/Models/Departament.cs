using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Upwork_2019_08_08.Models
{
    // "Departaments" table from DB
    public class Departament
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Client> Client { get; set; }
        public ICollection<AmAndClient> amAndClients { get; set; }
    }
}
