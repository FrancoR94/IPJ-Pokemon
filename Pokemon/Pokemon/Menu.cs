using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class Menu
{
    public Menu()
    {
        string[] lines = File.ReadAllLines("Bienvenida.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(150);
        }
        Console.WriteLine("Press ENTER to start...");
        Console.ReadLine();
        Console.Clear();
        MainMenu();
    }
    public static void MainMenu()
    {
        string[] lines = File.ReadAllLines("MenuPrincipal.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(50);
        }
        Console.ReadLine();
    }
}


