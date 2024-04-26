using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class MachineVersionDetail
    {
        public Machine machine {  get; set; }

        public VersionGroup version_group { get; set; }
    }
}