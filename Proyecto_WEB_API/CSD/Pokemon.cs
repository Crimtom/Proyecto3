using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Pokemon
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int base_experience { get; set; }

        public int height { get; set; }

        public bool is_default { get; set; }

        public int order { get; set; }

        public int weight { get; set; }

        public List<PokemonAbility> abilities { get; set; }

        public List<PokemonForm> forms { get; set; }

        public List<VersionGameIndex> game_indices { get; set; }

        public List<PokemonHeldItem> held_items { get; set; }

        public string location_area_encounters { get; set; }

        public List<PokemonMove> moves { get; set; }

        public List<PokemonTypePast> past_types { get; set; }

        public PokemonSprites sprites { get; set; }

        public PokemonCries cries { get; set; }

        public PokemonSpecies species { get; set; }

        public List<PokemonStat> stats { get; set; }

        public List<PokemonType> types { get; set; }
    }
}