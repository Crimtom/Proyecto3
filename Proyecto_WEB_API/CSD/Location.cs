using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Location
    {
        public int id {  get; set; }

        public string name { get; set; }

        public Region region { get; set; }

        public List<Name> names { get; set; }

        public List<GenerationGameIndex> game_indices { get; set; }

        public List<LocationArea> areas { get; set; }
    }
}