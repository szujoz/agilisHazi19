using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RegisTruck
{
    public class Serializer
    {
        public String PackageEntry { get; set; }

        public Serializer()
        {
            PackageEntry = "";
        }

        public string ToJson(object Obj)
        {
            string jsonString = JsonSerializer.Serialize(Obj);

            return jsonString;
        }

        public Package PackageFromJson(String json)
        {
            Package package = new Package();

            package = JsonSerializer.Deserialize<Package>(json);

            return package;
        }
    }
}
