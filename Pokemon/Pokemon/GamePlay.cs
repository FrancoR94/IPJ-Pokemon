using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class GamePlay
{
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
                Player player = new Player();
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

