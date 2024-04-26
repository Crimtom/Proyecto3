using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class BerryFirmness
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<Berry> berries { get; set; }

        public Name names { get; set; }
    }
}