using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Configuration;

namespace Proyecto_WEB_API.CSD
{
    public class Move
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int accuracy { get; set; }

        public int effect_chance { get; set; }

        public int pp {  get; set; }

        public int priority { get; set; }

        public int power { get; set; }

        public ContestComboSets contest_combos { get; set; }

        public ContestType contest_type { get; set; }

        public ContestEffect contest_effect { get; set; }

        public DamageClass damage_class { get; set; }

        public List<VerboseEffect> effect_entries { get; set; }

        public List<AbilityEffectChange> effect_changes { get; set; }

        public List<MoveFlavorText> flavor_text_entries { get; set; }

        public Generation generation { get; set; }

        public List<MachineVersionDetail> machines { get; set; }

        public List<Name> names { get; set; }

        public List<PasrMoveStatValues> past_values { get; set; }

        public List<MoveStatChange> stat_changes { get; set; }

        public ContestEffect super_contest_effect { get; set; }

        public MoveTarget target { get; set; }

        public Type type { get; set; }
    }
}