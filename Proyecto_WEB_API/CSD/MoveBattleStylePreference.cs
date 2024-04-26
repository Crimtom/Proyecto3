using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class MoveBattleStylePreference
    {
        public int low_hp_preference {  get; set; }

        public int high_hp_preference { get; set ; }

        public MoveBattleStyle move_battle_style { get; set; }
    }
}