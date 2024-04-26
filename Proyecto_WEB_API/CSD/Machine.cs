using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Machine
    {
        public int id {  get; set; }

        public Item item { get; set; }

        public Move move { get; set; }

        public VersionGroup version_group { get; set; }
    }
}