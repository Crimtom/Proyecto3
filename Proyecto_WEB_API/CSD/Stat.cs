using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Stat
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int game_index { get; set; }

        public bool is_battle_only { get; set; }

        public MoveStatAffectSets affecting_moves { get; set; }

        public NatureStatAffectSets affecting_natures { get; set; }

        public List<Characteristic> characteristics { get; set; }

        public MoveDamageClass move_damage_class { get; set; }

        public List<Name> names { get; set; }
    }
}