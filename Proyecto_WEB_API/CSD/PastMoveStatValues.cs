using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PastMoveStatValues
    {
        public int accuracy {  get; set; }

        public int effect_chance { get; set; }

        public int power { get; set; }

        public int pp {  get; set; }

        public List<VerboseEffect> effect_entries { get; set; }

        public Type type { get; set; }

        public VersionGroup version_group { get; set; }
    }
}