﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Upwork_2019_08_08.Models
{
    // "Clients" table from DB
    public class ClientUser
    {
    
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string email { get; set; }
        public DateTime? createdDate { get; set; }
        public int? createdBy { get; set; }
        public bool? isActive { get; set; }
        public int? lastModifiedBy { get; set; }
        public int? companyID { get; set; }
        public bool? isDeleted { get; set; }


        public AdminUser AdminUser { get; set; }
        public Company Company { get; set; }


        public ICollection<LogHistorie> LogHistorie { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
        public ICollection<Ticket> Tickets { get; set; }




    }
}
