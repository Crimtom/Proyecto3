using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Region
    {
        public int id {  get; set; }

        public List<Location> locations { get; set; }

        public string name { get; set; }

        public Generation main_generation { get; set; }

        public List<Pokedex> pokedexes { get; set; }

        public List<VersionGroup> version_groups { get; set; }
    }
}