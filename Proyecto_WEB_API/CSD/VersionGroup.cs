using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class VersionGroup
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int order { get; set; }

        public Generation generation { get; set; }

        public MoveLearnMethod move_learn_methods { get; set; }

        public Pokedex pokedexes { get; set; }

        public List<Region> regions { get; set; }

        public Version versions { get; set; }
    }
}