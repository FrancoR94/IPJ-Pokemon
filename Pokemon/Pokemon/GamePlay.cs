using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class GamePlay
{
   
    public List<Enemy> enemies;

    
    public GamePlay()
    {
        enemies = new List<Enemy>();
        enemies.Add(new Enemy("Broke"));
        enemies.Add(new Enemy("Misty"));
        enemies.Add(new Enemy("Sabrina"));

        
    }
    public void Gameplay()
    {
        
        Battle battle = new Battle();

    }

}

