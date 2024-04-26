using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Language
    {
        public int id {  get; set; }

        public string name { get; set; }

        public bool official { get; set; }

        public string iso639 { get; set; }

        public string iso3166 { get; set; }

        public List<Name> names { get; set; }
    }
}