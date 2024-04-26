using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonStat
    {
        public Stat stat {  get; set; }

        public int effort { get; set; }

        public int base_stat { get; set; }
    }
}