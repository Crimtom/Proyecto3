using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Ability
    {
        public int id {  get; set; }

        public string name { get; set; }

        public bool is_main_series { get; set; }

        public Generation generation { get; set; }

        public List<Name> names { get; set; }

        public List<VerboseEffect> effect_entries { get; set; }

        public List<AbilityEffectChange> effect_changes { get; set; }

        public List<AbilityPokemon> pokemon {  get; set; }
    }
}