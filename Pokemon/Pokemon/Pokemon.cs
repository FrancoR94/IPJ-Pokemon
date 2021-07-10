using System;
using System.Collections.Generic;
using System.Text;
using static System.Convert;


public class Pokemon
{
    public string name;
    public int level;
    public List<Tipo> types;
    public int life;
    public int maxLife;
    public int attack;
    public int specialAttack;
    public int defense;
    public int specialDefense;
    public int speed;
    public PokemonState state;
    public List<Movement> moves;
    public Movement movement;

    public Pokemon()
    {
        types = new List<Tipo>();
        moves = new List<Movement>();
    }
    public void BonifDamage(Pokemon caster, Pokemon objective)
    {
        double bonif = 1.5;
        double efectivity = 1.2;
        Random random = new Random();
        random.Next(80, 101);
        double damage = (0.01*bonif*efectivity*ToDouble(random)*((((0.2*caster.level+1)*caster.attack*movement.potencia)/(25*objective.defense))+2));
    }
    /*public Pokemon(string name,int level, int life, int maxLife,int attack,int specialAttack,int defense,int specialDefense,int speed)
    {
        this.name = name;
        this.level = level;
        this.maxLife = maxLife;
        this.attack = attack;
        this.specialAttack = specialAttack;
        this.defense = defense;
        this.specialDefense = specialDefense;
        this.speed = speed;
    }*/

}

