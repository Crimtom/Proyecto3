using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class SuperContestEffect
    {
        public int id {  get; set; }

        public int appeal { get; set; }

        public List<FlavorText> flavor_text_entries { get; set; }

        public List<Move> moves { get; set; }
    }
}