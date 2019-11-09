using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisTruck
{
    public enum PackageType
    {
        Invalid = 0,
        Normal,
        Fragile,
        Custom,
        Priority
    }

    public class Package
    {
        public int Id { get; set; }

        public int DestinationStationId { get; set; }

        public double Weight { get; set; }

        public String Deadline { get; set; }

        public PackageType Type { get; set; }

        public String Description { get; set; }


        public Package()
        {
            Id = -1;
            DestinationStationId = -1;
            Weight = -1;
            Deadline = "2000.01.01";
            Type = PackageType.Invalid;
            Description = "";
        }

        public Package(int         id,
                       int         dst,
                       double      weight,
                       String      deadline,
                       PackageType type,
                       String      desc)
        {
            Id = id;
            DestinationStationId = dst;
            Weight = weight;
            Deadline = deadline;
            Type = type;
            Description = desc;
        }
    }
}
