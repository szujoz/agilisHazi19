using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisTruck
{
    enum PackageType
    {
        Invalid = 0,
        Normal,
        Fragile,
        Custom,
        Priority
    }

    class Package
    {
        public int Id { get; set; }

        public int DestinationStationId { get; set; }

        public int Weight { get; set; }

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
    }
}
