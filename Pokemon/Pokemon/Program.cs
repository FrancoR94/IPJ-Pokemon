using System;


    class Program
    {
        static void Main(string[] args)
        {
            Game game = Game.GetInstence();
            bool gameOpen = true;
            do
            {
            gameOpen = game.GameStart();
            } while (gameOpen);
        }
    }

