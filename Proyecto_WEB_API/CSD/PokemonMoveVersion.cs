using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonMoveVersion
    {
        public MoveLearnMethod move_learn_method {  get; set; }

        public VersionGroup VersionGroup { get; set; }

        public int level_learned_at { get; set; }
    }
}