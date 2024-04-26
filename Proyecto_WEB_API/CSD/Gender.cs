using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Gender
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<PokemonSpeciesGender> pokemon_species_details { get; set; }

        public List<PokemonSpecies> required_for_evolution { get; set; }
    }
}