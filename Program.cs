using System;

namespace Game_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Random random = new Random();

            Console.WriteLine("Hello and welcome to (Game name here)");
            Console.WriteLine("Created by (Company name here)");
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add new player");
            Console.WriteLine("2. Increase all players main skills by ammount");
            Console.WriteLine("3. Decrease all players main skills by ammount");
            Console.WriteLine("4. Dump all information");
            Console.WriteLine("5. Change all players cooking to");
            var menu = Console.ReadLine();
            
            if (menu == "1")
            {
                Console.WriteLine("Enter player name");
                player.userName = Console.ReadLine();
                Console.WriteLine("Enter clan name");
                player.clanName = Console.ReadLine();
                player.healthLevel = random.Next(0, 120);
                player.attackLevel = random.Next(0, 120);
                player.defenceLevel = random.Next(0, 120);
                player.cookingLevel = random.NextDouble();
            }

            if (menu == "2")
            {
                Console.WriteLine("Enter the amount by witch to increase: ");
                var increase = Convert.ToInt32(Console.ReadLine());
                player.IncreaseHealthDefenceAndAttackBy(increase);
            }

            if (menu == "3")
            {
                Console.WriteLine("Enter the amount by witch to decrease: ");
                var decrease = Convert.ToInt32(Console.ReadLine());
                player.DecreaseHealthDefenceAndAttackBy(decrease);
            }

            if (menu == "4")
            {
                Console.WriteLine("Dumping all player info: ");
                Console.WriteLine();
                //Console.WriteLine(player.Race);
                Console.WriteLine($"Username: {player.userName}");
                Console.WriteLine($"Clan: {player.clanName}");
                Console.WriteLine($"Health level: {player.healthLevel}");
                Console.WriteLine($"Attack level: {player.attackLevel}");
                Console.WriteLine($"Defence level: {player.defenceLevel}");
                Console.WriteLine($"Coocking level: {player.cookingLevel}");
            }

            if (menu == "5")
            {
                Console.WriteLine("Enter the desired coocking level: ");
                var num = Convert.ToInt32(Console.ReadLine());
                var change = num - player.cookingLevel;
                player.IncreaseCookingBy(change);
            }

        }
        public class Player
        {
            public string userName { get; set; }
            public string clanName { get; set; }
            public int healthLevel { get; set; }
            public int defenceLevel { get; set; }
            public int attackLevel { get; set; }
            public double cookingLevel { get; set; }
            //public enum Race { get; set; }
            public static void Greet()
            {
                Player player = new Player();
                var greetings = $"Greetings, my name is {player.userName} and I am a sworn fighter of {player.clanName}!";
            }
            public static void SayLevels()
            {
                Player player = new Player();
                var levels = $"My level in Health is {player.healthLevel}, " +
                    $"defence is {player.defenceLevel}, " +
                    $"attack is {player.attackLevel} " +
                    $"and coocking is {player.cookingLevel}";
            }
            public void IncreaseHealthDefenceAndAttackBy(int increase)
            {
                Player player = new Player();
                var maxCombat = 120;

                    if (player.healthLevel < maxCombat)
                    {
                        if (player.healthLevel + increase < maxCombat)
                        {
                            player.healthLevel += increase;
                            Console.WriteLine($"Health was increased by {increase} and now is {player.healthLevel}");
                        }
                        else
                        {
                            player.healthLevel = maxCombat;
                            Console.WriteLine($"Health could not be increased by desired amount (max level reached) and is now {player.healthLevel}");
                        }
                    }
                    else Console.WriteLine($"Health level is maxed out: {player.healthLevel}");

                    if (player.defenceLevel < maxCombat)
                    {
                        if (player.defenceLevel + increase < maxCombat)
                        {
                            player.defenceLevel += increase;
                            Console.WriteLine($"Health was increased by {increase} and now is {player.defenceLevel}");
                        }
                        else
                        {
                            player.defenceLevel = maxCombat;
                            Console.WriteLine($"Health could not be increased by desired amount (max level reached) and is now {player.defenceLevel}");
                        }
                    }
                    else Console.WriteLine($"Defence level is maxed out: {player.defenceLevel}");

                    if (player.attackLevel < maxCombat)
                    {
                        if (player.attackLevel + increase < maxCombat)
                        {
                            player.attackLevel += increase;
                            Console.WriteLine($"Health was increased by {increase} and now is {player.attackLevel}");
                        }
                        else
                        {
                            player.attackLevel = maxCombat;
                            Console.WriteLine($"Health could not be increased by desired amount (max level reached) and is now {player.attackLevel}");
                        }
                    }
                    else Console.WriteLine($"Attack level is maxed out: {player.attackLevel}");

            }
            public void DecreaseHealthDefenceAndAttackBy(int decrease)
            {
                Player player = new Player();
                var minCombat = 0;

                    if (player.healthLevel > minCombat)
                    {
                        if (player.healthLevel - decrease > minCombat)
                        {
                            player.healthLevel -= decrease;
                            Console.WriteLine($"Health was reduced by {decrease} and now is {player.healthLevel}");
                        }
                        else
                        {
                            player.healthLevel = minCombat;
                            Console.WriteLine($"Health could not be decreased by desired amount (min level reached) and is now {player.healthLevel}");
                        }
                    }
                    else Console.WriteLine($"Health level is at lowest level: {player.healthLevel}");

                    if (player.defenceLevel > minCombat)
                    {
                        if (player.defenceLevel - decrease > minCombat)
                        {
                            player.defenceLevel -= decrease;
                            Console.WriteLine($"Defence was decreased by {decrease} and now is {player.defenceLevel}");
                        }
                        else
                        {
                            player.defenceLevel = minCombat;
                            Console.WriteLine($"Defence could not be decreased by desired amount (min level reached) and is now {player.defenceLevel}");
                        }
                    }
                    else Console.WriteLine($"Defence level is at lowest level: {player.defenceLevel}");

                    if (player.attackLevel > minCombat)
                    {
                        if (player.attackLevel - decrease > minCombat)
                        {
                            player.attackLevel -= decrease;
                            Console.WriteLine($"Attack was increased by {decrease} and now is {player.attackLevel}");
                        }
                        else
                        {
                            player.attackLevel = minCombat;
                            Console.WriteLine($"attack could not be decreased by desired amount (min level reached) and is now {player.attackLevel}");
                        }
                    }
                    else Console.WriteLine($"Attack level is at lowest level: {player.attackLevel}");

            }
            public void IncreaseCookingBy(double num)
            {
                Player player = new Player();
                var minCooking = 0.00f;
                var maxCooking = 1.00f;

                if (num > 0)
                {
                    if (player.cookingLevel < maxCooking)
                    {
                        if (player.cookingLevel + num < maxCooking)
                        {
                            player.cookingLevel += num;
                            Console.WriteLine($"Cooking was increased by {num} and now is {player.cookingLevel}");
                        }
                        else
                        {
                            player.cookingLevel = maxCooking;
                            Console.WriteLine($"Coocking could not be increased by desired amount (max level reached) and is now {player.cookingLevel}");
                        }
                    }
                    else Console.WriteLine($"Cooking level is maxed out: {player.cookingLevel}");
                }
                else
                {
                    if (player.cookingLevel > minCooking)
                    {
                        if (player.cookingLevel + num > minCooking)
                        {
                            player.cookingLevel += num;
                            Console.WriteLine($"Cooking was decreased by {num} and now is {player.cookingLevel}");
                        }
                        else
                        {
                            player.cookingLevel = minCooking;
                            Console.WriteLine($"Coocking could not be decreased by desired amount (max level reached) and is now {player.cookingLevel}");
                        }
                    }
                    else Console.WriteLine($"Cooking level is at lowest level: {player.cookingLevel}");
                }
            }

        }
    }
}
