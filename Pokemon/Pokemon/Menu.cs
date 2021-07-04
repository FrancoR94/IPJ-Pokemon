using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


class Menu
{
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


