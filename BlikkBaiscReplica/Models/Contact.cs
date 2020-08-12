﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlikkBaiscReplica.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address VisitingAddress { get; set; }

        [JsonIgnore]
        public ApplicationUser ApplicationUser { get; set; }

        [JsonIgnore]
        public string ApplicationUserId { get; set; }
    }
}
