using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class LocationArea
    {

        public int id {  get; set; }

        public string name { get; set; }

        public int game_index { get; set; }

        public List<EncounterMethodRate> encounter_method_rates { get; set; }

        public Location location { get; set; }

        public List<Name> names { get; set; }

        public List<PokemonEncounter> pokemon_encounters { get; set; }
    }
}