using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{

    // Get Relations between Account Manager and Clients from DB
    public class AmAndDepartament
    {
        [Key]
        public int id { get; set; }
        public int departamentID { get; set; }
        public int amID { get; set; }
        public DateTime assignedTime { get; set; }

        [ForeignKey("departamentID")]
        public Departament Departament { get; set; }
        public Admin Admin { get; set; }
    }
}
