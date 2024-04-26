using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class Type
    {
        public int id {  get; set; }

        public string name { get; set; }

        public TypeRelations damage_relations { get; set; }

        public List<Type> past_damage_relations { get; set; }

        public GenerationGameIndex game_indices { get; set; }

        public Generation generation { get; set; }

        public MoveDamageClass move_damage_class { get; set; }

        public List<Name> names { get; set; }

        public List<TypePokemon> pokemon {  get; set; }

        public List<Move> moves { get; set; }
    }
}