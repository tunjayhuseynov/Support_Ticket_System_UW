using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    // "Admins" table from DB
    public class AdminUser
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string email { get; set; }
        public int? whoIs { get; set; }
        public bool? isDelete { get; set; }
        public bool? isActive { get; set; }
        public string cellNumber { get; set; }

        [ForeignKey("amID")]
        public ICollection<AmAndDepartament> amAndDepartament { get; set; }

        [ForeignKey("createdBy")]
        public ICollection<Company> Departament { get; set; }

        [ForeignKey("createdBy")]
        public ICollection<ClientUser> ClientUsers { get; set; }

        [ForeignKey("whoIs")]
        public AdminRole AdminRole { get; set; }
    }
}
