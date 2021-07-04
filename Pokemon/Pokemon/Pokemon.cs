using System;
using System.Collections.Generic;
using System.Text;


class Pokemon
{
    private string name;
    private int level;
    private string type;
    private int life;
    private int maxLife;
    private int attack;
    private int specialAttack;
    private int defense;
    private int specialDefense;
    private int speed;
    private List<Movement> moves;

    public Pokemon()
    {
        moves = new List<Movement>();
    }

}

