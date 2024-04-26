using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonSpeciesDexEntry
    {
        public int entry_number {  get; set; }

        public Pokedex pokedex { get; set; }
    }
}