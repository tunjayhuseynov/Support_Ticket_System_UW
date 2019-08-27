using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Upwork_2019_08_08.Models
{
    // "Departaments" table from DB
    public class Company
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactperson { get; set; }
        public string email { get; set; }
        public DateTime? createdDate { get; set; }
        public int? createdBy { get; set; }
        public bool? isActive { get; set; }
        public DateTime? activedate { get; set; }
        public int? lastModifiedBy { get; set; }
        public bool? isDelete { get; set; }

        public Admin Admin { get; set; }
        
        public ICollection<AmAndDepartament> amAndDepartament { get; set; }
       
        public ICollection<DepartamentUser> DepartamentUser { get; set; }
        public ICollection<Client> Client { get; set; }


    }
}
