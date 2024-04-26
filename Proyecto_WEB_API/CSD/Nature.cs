using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Nature
    {
        public int id {  get; set; }

        public string name { get; set; }

        public Stat decreased_stat { get; set; }

        public Stat increased_stat { get; set; }

        public BerryFlavor likes_flavor { get; set; }

        public List<NatureStatChange> pokeathlon_stat_changes { get; set; }

        public List<MoveBattleStylePreference> move_battle_style_preferences { get; set; }

        public List<Name> names {  get; set; }
    }
}