﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class LocationAreaEncounter
    {
        public LocationArea location_area {  get; set; }

        public List<VersionEncounterDetail> version_details { get; set; }
    }
}