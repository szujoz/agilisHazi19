using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisTruck
{
    public class Truck
    {
        public string        Type         { get; set; }
        public string        SerialNumber { get; set; }
        public int           Weight       { get; set; }
        public int           Capacity     { get; set; }
        public double        LiftHeight   { get; set; }
        public string        Operator     { get; set; }
        public int           RepairState  { get; set; }
        public List<Package> Payload      { get; set; }

        public Truck()
        {
            Type = "";
            SerialNumber = "";
            Weight = -1;
            Capacity = -1;
            LiftHeight = -1;
            Operator = "";
            RepairState = -1;
            Payload = new List<Package>();
        }

        public Truck(string type,
                     string snum,
                     int weight,
                     int capac,
                     double lift,
                     string oper,
                     int repair,
                     List<Package> payload)
        {
            LoadInfo(type, snum, weight, capac, lift, oper, repair, payload);
        }

        public void LoadInfo(string type,
                             string snum,
                             int weight,
                             int capac,
                             double lift,
                             string oper,
                             int repair,
                             List<Package> payload)
        {
            Type = type;
            SerialNumber = snum;
            Weight = weight;
            Capacity = capac;
            LiftHeight = lift;
            Operator = oper;
            RepairState = repair;
            Payload = payload;
        }

        public double GetPayloadWeight()
        {
            double pWeight = 0;

            if (Payload.Count > 0)
            {
                foreach (var package in Payload)
                {
                    pWeight += package.Weight;
                }
            }

            return pWeight;
        }
    }
}
