using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Generation
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<Ability> abilities { get; set; }

        public List<Name> names { get; set; }

        public Region main_region { get; set; }

        public List<Move> moves { get; set; }

        public List<PokemonSpecies> pokemon_species { get; set; }

        public List<Type> types { get; set; }

        public List<VersionGroup> version_groups { get; set; }
    }
}