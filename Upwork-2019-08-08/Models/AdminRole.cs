using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    public class AdminRole
    {   [Key]
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<AdminUser> AdminUsers { get; set; }
    }
}
