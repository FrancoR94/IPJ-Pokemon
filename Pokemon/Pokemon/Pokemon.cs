using System;
using System.Collections.Generic;
using System.Text;


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

    public Pokemon()
    {
        types = new List<Tipo>();
        moves = new List<Movement>();
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

