using System;
using System.Collections.Generic;
using System.Text;



public abstract class PokemonState
{
    public abstract Pokemon ApplyEffect(Pokemon affected);
}

