using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class NaturePokeathlonStatAffectSets
    {
        public List<NaturePokeathlonStatAffect> increase {  get; set; }

        public List<NaturePokeathlonStatAffect> decrease { get; set; }
    }
}