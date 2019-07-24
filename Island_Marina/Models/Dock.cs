using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Island_Marina.Models
{
    public class Dock
    {
        public Dock() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public int WaterService { get; set; }
        public int ElectricalService { get; set; }
    }
}