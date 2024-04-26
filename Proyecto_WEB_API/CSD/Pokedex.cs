using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Pokedex
    {
        public int id {  get; set; }

        public string name { get; set; }

        public bool is_main_series { get; set; }

        public List<Description> descriptions { get; set; }

        public List<Name> names { get; set; }

        public Region region { get; set; }

        public List<VersionGroup> version_groups { get; set; }
    }
}