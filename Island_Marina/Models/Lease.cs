using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Island_Marina.Models
{
    public class Lease
    {
        public Lease() { }
        public int ID { get; set; }
        public int SlipID { get; set; }
        public int CustomerID { get; set; }
    }
}