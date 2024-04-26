﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class EncounterCondition
    {
        public int id {  get; set; }

        public string name { get; set; }

        public List<Name> names { get; set; }

        public List<EncounterConditionValue> values { get; set; }
    }
}