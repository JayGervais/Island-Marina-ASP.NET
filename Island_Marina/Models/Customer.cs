﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Island_Marina.Models
{
    public class Customer
    {
        public Customer() { }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}