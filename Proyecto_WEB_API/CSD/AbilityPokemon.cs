using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class AbilityPokemon
    {
        public bool is_hidden {  get; set; }

        public int slot { get; set; }

        public PokemonEncounter pokemon {  get; set; }
    }
}