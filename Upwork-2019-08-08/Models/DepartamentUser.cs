using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class DepartamentUser
    {
        public int id { get; set; }
        public int clientID { get; set; }
        public int departamentID { get; set; }
        public DateTime assignedTime { get; set; }

        public Client Client { get; set; }

        [ForeignKey("departamentID")]
        public Departament Departament { get; set; }
    }
}
