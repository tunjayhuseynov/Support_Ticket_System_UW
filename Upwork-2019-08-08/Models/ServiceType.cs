using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class ServiceType
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Detail> details { get; set; }
    }
}
