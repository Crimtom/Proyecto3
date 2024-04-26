using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class EvolutionChain
    {
        public int id {  get; set; }

        public Item baby_trigger_item { get; set; }

        public ChainLink chain {  get; set; }
    }
}