using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype
{
    public class Players
    {
        public List<Player> PlayerList { get; set; }
        public void AllPlayers()
        {
            var player = new Player();
            PlayerList = new List<Player>();
            PlayerList.Add(player);
        }

        public void PlayerGreeting()
        {
            var players = new List<Player>();

            foreach (var p in players)
                p.Greet();
        }

        public void PlayerLevels()
        {
            var players = new List<Player>();

            foreach (var p in players)
            {
                p.DataDump();
            }
        }

        public void IncreaseHealthDefenceAndAttackBy(int increase)
        {
            var players = new List<Player>();
            var maxCombat = 120;

            foreach (var p in players)
            {
                if (p.HealthLevel < maxCombat)
                {
                    if (p.HealthLevel + increase < maxCombat)
                    {
                        p.HealthLevel += increase;
                        Console.WriteLine($"Health was increased by {increase} and now is {p.HealthLevel}");
                    }
                    else
                    {
                        p.HealthLevel = maxCombat;
                        Console.WriteLine($"Health could not be increased by desired amount (max level reached) and is now {p.HealthLevel}");
                    }
                }
                else Console.WriteLine($"Health level is maxed out: {p.HealthLevel}");

                if (p.DefenceLevel < maxCombat)
                {
                    if (p.DefenceLevel + increase < maxCombat)
                    {
                        p.DefenceLevel += increase;
                        Console.WriteLine($"Health was increased by {increase} and now is {p.DefenceLevel}");
                    }
                    else
                    {
                        p.DefenceLevel = maxCombat;
                        Console.WriteLine($"Health could not be increased by desired amount (max level reached) and is now {p.DefenceLevel}");
                    }
                }
                else Console.WriteLine($"Defence level is maxed out: {p.DefenceLevel}");

                if (p.AttackLevel < maxCombat)
                {
                    if (p.AttackLevel + increase < maxCombat)
                    {
                        p.AttackLevel += increase;
                        Console.WriteLine($"Health was increased by {increase} and now is {p.AttackLevel}");
                    }
                    else
                    {
                        p.AttackLevel = maxCombat;
                        Console.WriteLine($"Health could not be increased by desired amount (max level reached) and is now {p.AttackLevel}");
                    }
                }
                else Console.WriteLine($"Attack level is maxed out: {p.AttackLevel}");
            }
        }

        public void DecreaseHealthDefenceAndAttackBy(int decrease)
        {
            var players = new List<Player>();
            var minCombat = 0;

            foreach (var p in players)
            {
                if (p.HealthLevel > minCombat)
                {
                    if (p.HealthLevel - decrease > minCombat)
                    {
                        p.HealthLevel -= decrease;
                        Console.WriteLine($"Health was reduced by {decrease} and now is {p.HealthLevel}");
                    }
                    else
                    {
                        p.HealthLevel = minCombat;
                        Console.WriteLine($"Health could not be decreased by desired amount (min level reached) and is now {p.HealthLevel}");
                    }
                }
                else Console.WriteLine($"Health level is at lowest level: {p.HealthLevel}");

                if (p.DefenceLevel > minCombat)
                {
                    if (p.DefenceLevel - decrease > minCombat)
                    {
                        p.DefenceLevel -= decrease;
                        Console.WriteLine($"Defence was decreased by {decrease} and now is {p.DefenceLevel}");
                    }
                    else
                    {
                        p.DefenceLevel = minCombat;
                        Console.WriteLine($"Defence could not be decreased by desired amount (min level reached) and is now {p.DefenceLevel}");
                    }
                }
                else Console.WriteLine($"Defence level is at lowest level: {p.DefenceLevel}");

                if (p.AttackLevel > minCombat)
                {
                    if (p.AttackLevel - decrease > minCombat)
                    {
                        p.AttackLevel -= decrease;
                        Console.WriteLine($"Attack was increased by {decrease} and now is {p.AttackLevel}");
                    }
                    else
                    {
                        p.AttackLevel = minCombat;
                        Console.WriteLine($"attack could not be decreased by desired amount (min level reached) and is now {p.AttackLevel}");
                    }
                }
                else Console.WriteLine($"Attack level is at lowest level: {p.AttackLevel}");
            }

        }

        public void IncreaseCookingBy(double change)
        {
            var players = new List<Player>();
            var minCooking = 0.00f;
            var maxCooking = 1.00f;
            foreach (var p in players)
            {
                var num = change - p.CookingLevel;

                if (num > 0)
                {
                    if (p.CookingLevel < maxCooking)
                    {
                        if (p.CookingLevel + num < maxCooking)
                        {
                            p.CookingLevel += num;
                            Console.WriteLine($"Cooking was increased by {num} and now is {p.CookingLevel}");
                        }
                        else
                        {
                            p.CookingLevel = maxCooking;
                            Console.WriteLine($"Coocking could not be increased by desired amount (max level reached) and is now {p.CookingLevel}");
                        }
                    }
                    else Console.WriteLine($"Cooking level is maxed out: {p.CookingLevel}");
                }
                else
                {
                    if (p.CookingLevel > minCooking)
                    {
                        if (p.CookingLevel + num > minCooking)
                        {
                            p.CookingLevel += num;
                            Console.WriteLine($"Cooking was decreased by {num} and now is {p.CookingLevel}");
                        }
                        else
                        {
                            p.CookingLevel = minCooking;
                            Console.WriteLine($"Coocking could not be decreased by desired amount (max level reached) and is now {p.CookingLevel}");
                        }
                    }
                    else Console.WriteLine($"Cooking level is at lowest level: {p.CookingLevel}");
                }
            }
        }

        public void Start()
        {
            var tempOne = new Player();
            var tempTwo = new Players();

            Console.WriteLine("Menu");
            Console.WriteLine("1. Add new player");
            Console.WriteLine("2. Increase all players main skills by ammount");
            Console.WriteLine("3. Decrease all players main skills by ammount");
            Console.WriteLine("4. Dump all information");
            Console.WriteLine("5. Change all players cooking to");
            var menu = Console.ReadLine();

            if (menu == "1")
            {
                // var player = new Player();
                // player.Initialize();
                // Players.Add(player);

                Console.WriteLine("Enter player name");
                tempOne.UserName = Console.ReadLine();
                Console.WriteLine("Enter clan name");
                tempOne.ClanName = Console.ReadLine();
                tempOne.StatSet();
                tempTwo.AllPlayers();
            }

            if (menu == "2")
            {
                Console.WriteLine("Enter the amount by witch to increase: ");
                var increase = Convert.ToInt32(Console.ReadLine());
                tempTwo.IncreaseHealthDefenceAndAttackBy(increase);
            }

            if (menu == "3")
            {
                Console.WriteLine("Enter the amount by witch to decrease: ");
                var decrease = Convert.ToInt32(Console.ReadLine());
                tempTwo.DecreaseHealthDefenceAndAttackBy(decrease);
            }

            if (menu == "4")
            {
                Console.WriteLine("Dumping all player info: ");
                Console.WriteLine();
                tempTwo.PlayerLevels();
            }

            if (menu == "5")
            {
                Console.WriteLine("Enter the desired coocking level: ");
                tempTwo.IncreaseCookingBy(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
