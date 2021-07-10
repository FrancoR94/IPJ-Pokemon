using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class Menu
{
   
    enum MenuSelection { Start = 1, Exit, Error };
    public Menu()
    {
        
    }
    public void Welcome()
    {
        string[] lines = File.ReadAllLines("Mensajes/Bienvenida.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(150);
        }
        Console.WriteLine("Press ENTER to start...");
        Console.ReadLine();
        Console.Clear();
    }
    public void MainMenu()
    {
        Welcome();
        string[] lines = File.ReadAllLines("Mensajes/MenuPrincipal.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(50);
        }
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
                Console.ReadLine();
                Console.Clear();
                break;
            case MenuSelection.Exit:
                Console.Clear();
                string[] lines2 = File.ReadAllLines("Mensajes/Final.txt");
                foreach (string line in lines2)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(100);
                }
                break;
        }
        }
    public void PauseMenu()
    {
        string[] lines = File.ReadAllLines("Mensajes/MenuPausa.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(50);
        }
    }
}


