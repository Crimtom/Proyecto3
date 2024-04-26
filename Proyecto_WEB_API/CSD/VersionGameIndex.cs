using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class VersionGameIndex
    {
        public string text {  get; set; }

        public Language language { get; set; }

        public VersionGroup version_group { get; set; }
    }
}