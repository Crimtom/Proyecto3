﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Proyecto_WEB_API.CSD
{
    public class NamedAPIResourceList
    {
        public int count {  get; set; }

        public string next { get; set; }

        public string previous { get; set; }

        public List<NamedAPIResource> results { get; set; }
    }
}