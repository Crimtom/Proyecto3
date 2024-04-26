using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class GrowthRate
    {
        public int id {  get; set; }

        public string name { get; set; }

        public string formula { get; set; }

        public List<Description> descriptions { get; set; }

        public List<GrowthRateExperienceLevel> levels { get; set; }

        public List<PokemonSpecies> pokemon_species { get; set; }
    }
}