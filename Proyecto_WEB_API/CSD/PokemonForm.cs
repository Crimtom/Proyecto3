using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonForm
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int order { get; set; }

        public int form_order { get; set; }

        public bool is_default { get; set; }

        public bool is_mega { get; set; }

        public string form_name { get; set; }

        public Pokemon pokemon { get; set; }

        public List<PokemonFormType> types { get; set; }

        public PokemonFormSprites sprites { get; set; }

        public VersionGroup version_group { get; set; }

        public List<Name> names { get; set; }

        public List<Name> form_names { get; set; }
    }
}