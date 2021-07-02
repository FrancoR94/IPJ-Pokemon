using System;


    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool gameOpen = true;
            do
            {
            gameOpen = Game.GameStart();
            } while (gameOpen);
        }
    }

