using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class ChainLink
    {
        public bool is_baby {  get; set; }

        public PokemonSpecies species { get; set; }

        public List<EvolutionDetail> evolution_details { get; set; }

        public List<ChainLink> evolves_to {  get; set; }
    }
}