﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WEB_API.CSD
{
    public class PokemonEntry
    {
        public int entry_number {  get; set; }

        public PokemonSpecies pokemon_species { get; set; }
    }
}