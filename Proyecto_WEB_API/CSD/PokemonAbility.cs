using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonAbility
    {
        public bool is_hidden {  get; set; }

        public int slot { get; set; }

        public Ability ability { get; set; }
    }
}