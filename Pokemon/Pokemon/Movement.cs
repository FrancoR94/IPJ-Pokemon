using System;
using System.Collections.Generic;
using System.Text;


public abstract class Movement
{
    public string nombre;
    public int potencia;
    public int maxUses;
    public int presicion;
    public string tipo;
    public abstract Pokemon Use(Pokemon caster, Pokemon objective);
    public sealed class DefaultError : Movement
    {
        public DefaultError()
        {
            nombre = "DefaultError";
            potencia = 0;
            maxUses = 0;
            presicion = 0;
            tipo = "Normal";
        }

        public override Pokemon Use(Pokemon caster, Pokemon objective)
        {
            return objective;
        }
    }
}


public sealed class Tornado : Movement
{
    public Tornado()
    {
        nombre = "Tornado";
        potencia = 40;
        maxUses = 35;
        presicion = 100;
        tipo = "Volador";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.attack - objective.defense);
        return objective;
    }
}

public sealed class Psicorrayo : Movement
{
    public Psicorrayo()
    {
        nombre = "Psicorrayo";
        potencia = 65;
        maxUses = 20;
        presicion = 100;
        tipo = "Psiquico";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class VientoPlata : Movement
{
    public VientoPlata()
    {
        nombre = "Viento Plata";
        potencia = 6;
        maxUses = 5;
        presicion = 100;
        tipo = "Bicho";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Paralizador : Movement
{
    public Paralizador()
    {
        nombre = "Paralizador";
        potencia = 0;
        maxUses = 30;
        presicion = 75;
        tipo = "Planta";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Maldicion : Movement
{
    public Maldicion()
    {
        nombre = "Maldicion";
        potencia = 0;
        maxUses = 10;
        presicion = 0;
        tipo = "Fantasma";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Tinieblas : Movement
{
    public Tinieblas()
    {
        nombre = "Latigo cepa";
        potencia = 0;
        maxUses = 15;
        presicion = 100;
        tipo = "Planta";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class PunoSombra : Movement
{
    public PunoSombra()
    {
        nombre = "Puno Sombra";
        potencia = 60;
        maxUses = 20;
        presicion = 0;
        tipo = "Fantasma";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class BolaSombra : Movement
{
    public BolaSombra()
    {
        nombre = "Bola Sombra";
        potencia = 80;
        maxUses = 15;
        presicion = 100;
        tipo = "Fantasma";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Impactrueno : Movement
{
    public Impactrueno()
    {
        nombre = "Impactrueno";
        potencia = 40;
        maxUses = 30;
        presicion = 100;
        tipo = "Electrico";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class AtaqueRapido : Movement
{
    public AtaqueRapido()
    {
        nombre = "Ataque Rapido";
        potencia = 40;
        maxUses = 30;
        presicion = 100;
        tipo = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class ColmilloRayo : Movement
{
    public ColmilloRayo()
    {
        nombre = "Colmillo Rayo";
        potencia = 65;
        maxUses = 15;
        presicion = 95;
        tipo = "Electrico";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class OndaTrueno : Movement
{
    public OndaTrueno()
    {
        nombre = "Onda trueno";
        potencia = 0;
        maxUses = 20;
        presicion = 90;
        tipo = "Electrico";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Ascuas : Movement
{
    public Ascuas()
    {
        nombre = "Ascuas";
        potencia = 40;
        maxUses = 25;
        presicion = 100;
        tipo = "Fuego";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Lanzallamas : Movement
{
    public Lanzallamas()
    {
        nombre = "Lanzallamas";
        potencia = 90;
        maxUses = 15;
        presicion = 100;
        tipo = "Fuego";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class GiroFuego : Movement
{
    public GiroFuego()
    {
        nombre = "Giro Fuego";
        potencia = 35;
        maxUses = 15;
        presicion = 85;
        tipo = "Fuego";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class VeloSagrado : Movement
{
    public VeloSagrado()
    {
        nombre = "Velo Sagrado";
        potencia = 0;
        maxUses = 25;
        presicion = 0;
        tipo = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Vendaval : Movement
{
    public Vendaval()
    {
        nombre = "Vendaval";
        potencia = 110;
        maxUses = 10;
        presicion = 70;
        tipo = "Volador";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class AtaqueAla : Movement
{
    public AtaqueAla()
    {
        nombre = "Ataque Ala";
        potencia = 60;
        maxUses = 35;
        presicion = 100;
        tipo = "Volador";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Ciclon : Movement
{
    public Ciclon()
    {
        nombre = "Ciclon";
        potencia = 40;
        maxUses = 20;
        presicion = 100;
        tipo = "Dragon";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class LatigoCepa : Movement
{
    public LatigoCepa()
    {
        nombre = "Latigo cepa";
        potencia = 45;
        maxUses = 25;
        presicion = 100;
        tipo = "Planta";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class DanzaPetalo : Movement
{
    public DanzaPetalo()
    {
        nombre = "Danza Petalo";
        potencia = 120;
        maxUses = 10;
        presicion = 100;
        tipo = "Planta";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Drenadoras : Movement
{
    public Drenadoras()
    {
        nombre = "Drenadoras";
        potencia = 0;
        maxUses = 10;
        presicion = 90;
        tipo = "Planta";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class TormentaFloral : Movement
{
    public TormentaFloral()
    {
        nombre = "Tormenta Floral";
        potencia = 90;
        maxUses = 15;
        presicion = 100;
        tipo = "Planta";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Burbuja : Movement
{
    public Burbuja()
    {
        nombre = "Burbuja";
        potencia = 40;
        maxUses = 30;
        presicion = 100;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Hidrobomba : Movement
{
    public Hidrobomba()
    {
        nombre = "Hidrobomba";
        potencia = 100;
        maxUses = 5;
        presicion = 80;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class DefensaFerrea : Movement
{
    public DefensaFerrea()
    {
        nombre = "Defensa Ferrea";
        potencia = 0;
        maxUses = 15;
        presicion = 0;
        tipo = "Acero";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class PistolaDeAgua : Movement
{
    public PistolaDeAgua()
    {
        nombre = "Pistola de Agua";
        potencia = 40;
        maxUses = 25;
        presicion = 100;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Hidrochorro : Movement
{
    public Hidrochorro()
    {
        nombre = "Hidrochorro";
        potencia = 0;
        maxUses = 15;
        presicion = 0;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class AcuaCola : Movement
{
    public AcuaCola()
    {
        nombre = "Acua Cola";
        potencia = 90;
        maxUses = 10;
        presicion = 90;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class AcuaJet : Movement
{
    public AcuaJet()
    {
        nombre = "Acua Jet";
        potencia = 40;
        maxUses = 20;
        presicion = 100;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class RayoConfuso : Movement
{
    public RayoConfuso()
    {
        nombre = "Rayo Confuso";
        potencia = 0;
        maxUses = 10;
        presicion = 100;
        tipo = "Fantasma";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class RayoHielo : Movement
{
    public RayoHielo()
    {
        nombre = "Rayo Hielo";
        potencia = 90;
        maxUses = 10;
        presicion = 100;
        tipo = "Hielo";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class MegaCuerno : Movement
{
    public MegaCuerno()
    {
        nombre = "Mega Cuerno";
        potencia = 120;
        maxUses = 10;
        presicion = 85;
        tipo = "Bicho";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Cascada : Movement
{
    public Cascada()
    {
        nombre = "Cascada";
        potencia = 80;
        maxUses = 15;
        presicion = 100;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Agilidad : Movement
{
    public Agilidad()
    {
        nombre = "Agilidad";
        potencia = 0;
        maxUses = 30;
        presicion = 0;
        tipo = "Psiquico";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class PuyaNociva : Movement
{
    public PuyaNociva()
    {
        nombre = "Puya Nociva";
        potencia = 80;
        maxUses = 20;
        presicion = 100;
        tipo = "Veneno";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Placaje : Movement
{
    public Placaje()
    {
        nombre = "Placaje";
        potencia = 40;
        maxUses = 35;
        presicion = 100;
        tipo = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Relajo : Movement
{
    public Relajo()
    {
        nombre = "Relajo";
        potencia = 0;
        maxUses = 10;
        presicion = 0;
        tipo = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class Bostezo : Movement
{
    public Bostezo()
    {
        nombre = "Bostezo";
        potencia = 0;
        maxUses = 10;
        presicion = 0;
        tipo = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class RayoBurbuja : Movement
{
    public RayoBurbuja()
    {
        nombre = "Rayo Burbuja";
        potencia = 65;
        maxUses = 20;
        presicion = 100;
        tipo = "Agua";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}
public sealed class GiroRapido : Movement
{
    public GiroRapido()
    {
        nombre = "Giro Rapido";
        potencia = 20;
        maxUses = 40;
        presicion = 100;
        tipo = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        objective.life -= (caster.specialAttack - objective.specialDefense);
        return objective;
    }
}



