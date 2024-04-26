using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Encounter
    {
        public int min_level {  get; set; }

        public int max_level { get; set;}

        public List<EncounterConditionValue> condition_values { get; set; }

        public int chance { get; set; }

        public EncounterMethod method { get; set; }
    }
}