using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype
{
    public class GameManager
    {
        private List<Player> _players { get; } = new();
        public void AllPlayers()
        {
            var player = new Player();
            _players.Add(player);
        }

        public void PlayerGreeting()
        {
            foreach (var p in _players)
                p.Greet();
        }

        public void PlayerLevels()
        {
            foreach (var p in _players)
                p.DataDump();
        }

        public void IncreaseHealthDefenceAndAttackBy()
        {
            Console.WriteLine("Specify the increase amount: ");
            var increase = int.Parse(Console.ReadLine());
            foreach (var p in _players)
                p.IncreaseLevelsBy(increase);
        }

        public void DecreaseHealthDefenceAndAttackBy()
        {
            Console.WriteLine("Specify the decrease amount: ");
            var decrease = int.Parse(Console.ReadLine());
            foreach (var p in _players)
                p.DecreaseLevelsBy(decrease);

        }

        public void AdjustCooking()
        {
            Console.WriteLine("What level should it be(0-1): ");
            var change = double.Parse(Console.ReadLine());
            
            if (change is >= 0 and <= 1)
            {
                foreach (var player in _players)
                    player.SetCookingTo(change);
            }
            else
            {
                Console.WriteLine("You have entered a wrong amount (0-1)!");
                AdjustCooking();
            }
        }

        public void Start()
        {
            Console.WriteLine("\nMenu:\n" +
                "1. Add new player\n" +
                "2. Increase all players main skills by ammount\n" +
                "3. Decrease all players main skills by ammount\n" +
                "4. Dump all information\n" +
                "5. Change all players cooking to\n" +
                "6. Quit");

            var menu = int.Parse(Console.ReadLine());
            var playerWantsToQuit = false;

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Enter player name");
                    var userName = Console.ReadLine();
                    Console.WriteLine("Enter clan name");
                    var clanName = Console.ReadLine();
                    var player = new Player();
                    player.StatSet(userName, clanName);
                    AllPlayers();
                    break;
                case 2:
                    IncreaseHealthDefenceAndAttackBy();
                    break;
                case 3:
                    DecreaseHealthDefenceAndAttackBy();
                    break;
                case 4:
                    PlayerLevels();
                    break;
                case 5:
                    AdjustCooking();
                    break;
                case 6:
                    playerWantsToQuit = true;
                    break;
                default:
                    Console.WriteLine("I am sorry. but this doesn't work");
                    break;
            }

            if (playerWantsToQuit) return;
            else Start();
        }
    }
}
