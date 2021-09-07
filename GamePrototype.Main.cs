using System;

namespace GamePrototype
{
    class Program
    {
        //Use initializers
        //Don't use same names

        // Program.cs main method should only contain these two lines:
        // 1. var gameManager = new GameManager();
        // 2. gameManager.Start();

        // GameManager
        // collection of players prop List<Players> Player
        // handles the game loop


        // Player
        // should be responsible for changing it's own data
        // and dumping it's own data

        static void Main(string[] args)
        {
            var gameManager = new Players();

            Console.WriteLine("Hello and welcome to (Game name here)");
            Console.WriteLine("Created by (Company name here)");
            Console.WriteLine();

            while (true)
            {
                gameManager.Start();
            }

        }
    }
}
