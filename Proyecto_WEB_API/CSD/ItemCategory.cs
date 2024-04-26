using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class ItemCategory
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<Item> items { get; set; }

        public List<Name> names { get; set; }

        public ItemPocket pocket { get; set; }
    }
}