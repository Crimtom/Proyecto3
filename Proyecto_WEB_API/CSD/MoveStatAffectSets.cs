using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class MoveStatAffectSets
    {
        public List<MoveStatAffect> increase {  get; set; }

        public List<MoveStatAffect> decrease { get; set; }
    }
}