using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class VersionEncounterDetail
    {
        public Version Version { get; set; }

        public int max_chance { get; set; }

        public List<Encounter> encounter_details { get; set; }
    }
}