﻿using Proyecto_WEB_API.CSD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class FlavorText
    {
        public string flavor_text { get; set; }

        public Language language { get; set; }

        public Version version { get; set; }
    }
}