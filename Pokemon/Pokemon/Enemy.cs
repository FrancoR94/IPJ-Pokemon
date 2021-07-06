using System;
using System.Collections.Generic;
using System.Text;


class Enemy
{
    public string name;
    public List<Pokemon> pokemon;
    public Enemy(string name)
    {
        this.name = name;
    }
    /*public Enemy Misty()
    {
        return (Enemy)this.MemberwiseClone();
    }
    public Enemy Broke()
    {
        Enemy broke = (Enemy)this.MemberwiseClone();
        broke.name = String.Copy(name);
        return broke;
    }*/

}
