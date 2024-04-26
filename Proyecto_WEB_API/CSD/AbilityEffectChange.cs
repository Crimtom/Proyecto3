using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class AbilityEffectChange
    {
        public List<Effect> effect_entries {  get; set; }

        public VersionGroup version_group { get; set; }
    }
}