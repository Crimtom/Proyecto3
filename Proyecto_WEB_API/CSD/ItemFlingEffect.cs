using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class ItemFlingEffect
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<Effect> effect_entries { get; set; }

        public List<Item> items { get; set; }
    }
}