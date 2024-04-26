using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class TypeRelations
    {
        public List<Type> no_damage_to {  get; set; }

        public List<Type> half_damage_to { get; set; }

        public List<Type> double_damage_to { get; set; }

        public List<Type> no_damage_from { get; set; }

        public List<Type> half_damage_from { get; set; }

        public List<Type> double_damage_from { get; set; }
    }
}