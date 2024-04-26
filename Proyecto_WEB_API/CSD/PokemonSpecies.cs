using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonSpecies
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int order { get; set; }

        public int gender_rate { get; set; }

        public int capture_rate { get; set; }

        public int base_happiness { get; set; }

        public bool is_baby { get; set; }

        public bool is_mythical { get; set; }

        public int hatch_counter { get; set; }

        public bool has_gender_differences { get; set; }

        public bool forms_switchable { get; set; }

        public GrowthRate growth_rate { get; set; }

        public List<PokemonSpeciesDexEntry> pokedex_numbers { get; set; }

        public List<EggGroup> egg_groups { get; set; }

        public PokemonColor color { get; set; }

        public PokemonShape shape { get; set; }

        public PokemonSpecies evolves_from_species { get; set; }

        public EvolutionChain evolution_chain { get; set; }

        public PokemonHabitat habitat {  get; set; }

        public Generation generation { get; set; }

        public List<Name> names { get; set; }

        public List<PalParkEncounterArea> pal_park_encounters { get; set; }

        public List<FlavorText> flavor_text_entries { get; set; }

        public List<Description> form_descriptions { get; set; }

        public List<Genus> genera {  get; set; }

        public List<PokemonSpeciesVariety> varieties { get; set; }
    }
}