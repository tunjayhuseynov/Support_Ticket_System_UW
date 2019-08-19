using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class AmUser
    {
        [Key]
        public int AmID { get; set; }
        public int DepartamentID { get; set; }
        public int clientID { get; set; }
    }
}
