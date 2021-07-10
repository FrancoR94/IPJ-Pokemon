using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


class Battle
{
    List<Movement> movement = new List<Movement>();
    Player player;
    public Battle()
    {
        //BUscar metodo para leer toda la info de carpetas file directory path
        /*foreach (string file in Directory.EnumerateFiles("Player", "*.txt"))
        {
            string contents = File.ReadAllText(file);
        }*/
        

        Pokemon venasaur = ReadPokemonFile.ReadPokemonFromFile("Player/Venusaur.txt");
        Pokemon butterfree = ReadPokemonFile.ReadPokemonFromFile("Player/Butterfree.txt");
        Pokemon haunter = ReadPokemonFile.ReadPokemonFromFile("Player/Haunter.txt");
        Pokemon jolteon = ReadPokemonFile.ReadPokemonFromFile("Player/Jolteon.txt");
        Pokemon pidgeot = ReadPokemonFile.ReadPokemonFromFile("Player/Pidgeot.txt");
        Pokemon ninetails = ReadPokemonFile.ReadPokemonFromFile("Player/Ninetales.txt");
        Pokemon blastoise = ReadPokemonFile.ReadPokemonFromFile("Entrenadores/Misty/Blastoise.txt");
        Pokemon golduck = ReadPokemonFile.ReadPokemonFromFile("Entrenadores/Misty/Golduck.txt");
        Pokemon lapras = ReadPokemonFile.ReadPokemonFromFile("Entrenadores/Misty/Lapras.txt");
        Pokemon seaking = ReadPokemonFile.ReadPokemonFromFile("Entrenadores/Misty/Seaking.txt");
        Pokemon slowbro = ReadPokemonFile.ReadPokemonFromFile("Entrenadores/Misty/Slowbro.txt");
        Pokemon starmie = ReadPokemonFile.ReadPokemonFromFile("Entrenadores/Misty/Starmie.txt");

        Console.WriteLine("Your first fight is against the Gym Leader Misty");
        bool pokemonLeft = true;
        do
        {
            if (venasaur.speed > blastoise.speed)
            {
                playerTurn();
                Console.Clear();
                Console.WriteLine("Choose an attack pressing 1,2,3 or 4");
                int input = Convert.ToInt32(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        Console.WriteLine("Hola" + player.name);
                        break;
                }
                if (input==1)
                {
                    
                }
            }
            else
            {
                mistyTurn();
            }

        } while (pokemonLeft);
        
    }
  
    public void playerTurn()
    {
        string[] line= File.ReadAllLines("Player/Venusaur.txt");
        foreach (string lines in line)
        {
            Console.WriteLine(lines);
        }
    }
    public void mistyTurn()
    {
        string[] line = File.ReadAllLines("Misty/Venusaur.txt");
        foreach (string lines in line)
        {
            Console.WriteLine(lines);
        }
    }
    public void Damage(Pokemon venasaur)
    {
        
    }
}

