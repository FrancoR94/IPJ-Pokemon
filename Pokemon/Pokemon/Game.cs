using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;


public class Game
{
    public Game()
    {
        GamePlay gamePlay = new GamePlay();
    }
    public static bool GameStart()
    {
        string[] lines = File.ReadAllLines("Mensajes/Final.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(100);
        }
        return false;
    }
}
