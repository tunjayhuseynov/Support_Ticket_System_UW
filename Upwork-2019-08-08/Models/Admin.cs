﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Models
{
    // "Admins" table from DB
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string email { get; set; }
        public bool isAdmin { get; set; }

        public ICollection<AmAndClient> amAndClients { get; set; }

    }
}
