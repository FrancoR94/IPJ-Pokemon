using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class GamePlay
{
    private Player player;
    private Battle battle;
    private Enemy enemy;
    public List<Enemy> enemies;

    enum MenuSelection { Start = 1, Exit, Error };
    public GamePlay()
    {
        
    }
    public void Gameplay()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        MenuSelection menuSelection;
        if (input >= 1 && input < (int)MenuSelection.Error)
        {
            menuSelection = (MenuSelection)input;
        }
        else
        {
            menuSelection = MenuSelection.Error;
        }
        switch (menuSelection)
        {
            case MenuSelection.Start:
                Console.Clear();
                Console.WriteLine("Welcome new player, what's your name?");
                Player player = new Player(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Get ready, " + player.name + ", the battles are about to begin!");
                enemies = new List<Enemy>();
                enemies.Add(new Enemy("Broke"));
                enemies.Add(new Enemy("Misty"));
                enemies.Add(new Enemy("Sabrina"));
                foreach (Enemy line in enemies)
                {
                    Console.WriteLine(Enemy line);
                }

                break;
            case MenuSelection.Exit:
                Console.Clear();
                string[] lines = File.ReadAllLines("Mensajes/Final.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(100);
                }
                break;
        }
    }

}

