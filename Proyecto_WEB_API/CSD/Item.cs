using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Item
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int cost { get; set; }

        public int fling_power { get; set; }

        public FlingEffect fling_effect { get; set; }

        public List<ItemAttribute> attributes { get; set; }

        public ItemCategory category { get; set; }

        public List<VerboseEffect> effect_entries { get; set; }

        public List<VersionGroupFlavorText> flavor_text_entries { get; set; }

        public List<GenerationGameIndex> game_indices { get; set; }

        public List<Name> names { get; set; }

        public ItemSprites sprites { get; set; }

        public List<ItemHolderPokemon> held_by_pokemon {  get; set; }

        public List<EvolutionChain> baby_trigger_for {  get; set; }

        public List<MachineVersionDetail> machines { get; set; }
    }
}