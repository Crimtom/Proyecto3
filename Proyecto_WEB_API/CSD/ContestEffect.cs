using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class ContestEffect
    {
        public int id {  get; set; }

        public int appeal { get; set; }

        public int jam { get; set; }

        public List<Effect> effect_entries { get; set; }

        public List<FlavorText> flavor_text_entries { get; set; }
    }
}