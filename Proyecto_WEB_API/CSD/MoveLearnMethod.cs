using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class MoveLearnMethod
    {

        public int id {  get; set; }

        public string name { get; set; }

        public List<Description> descriptions { get; set; }

        public List<Name> names { get; set; }

        public List<VersionGroup> version_groups { get; set; }
    }
}