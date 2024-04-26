using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class BerryFlavor
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<FlavorBerryMap> berries { get; set; }

        public ContestType contest_type { get; set; }

        public Name names { get; set; }
    }
}