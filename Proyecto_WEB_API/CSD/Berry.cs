using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Proyecto_WEB_API.CSD
{
    public class Berry
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int growth_time { get; set; }

        public int max_harvest { get; set; }

        public int natural_gift_power { get; set; }

        public int size { get; set; }

        public int smoothness { get; set; }

        public int soil_dryness { get; set; }

        public BerryFirmness firmness { get; set; }

        public List<BerryFlavorMap> flavors { get; set; }

        public Item item { get; set; }

        public Type natural_gift_type { get; set; }


    }
}