using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisTruck
{
    public class Truck
    {
        public String Type { get; set; }
        public String SerialNumber { get; set; }
        public int Weight { get; set; }
        public int Capacity { get; set; }
        public double LiftHeight { get; set; }
        public String Operator { get; set; }
        public String RepairState { get; set; }
        public Package Payload { get; set; }

        public Truck()
        {

        }
    }
}
