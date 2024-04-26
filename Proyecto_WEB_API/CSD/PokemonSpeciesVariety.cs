using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonSpeciesVariety
    {
        public bool is_default {  get; set; }

        public Pokemon pokemon { get; set; }
    }
}