using System;

namespace GamePrototype
{
    public class Player
    {
        public string UserName { get; set; }
        public string ClanName { get; set; }
        public int HealthLevel { get; set; }
        public int DefenceLevel { get; set; }
        public int AttackLevel { get; set; }
        public double CookingLevel { get; set; }
        public Race Race { get; set; }

        public void StatSet()
        {
            var rng = new Random();
            var player = new Player();

            player.HealthLevel = rng.Next(0, 121);
            player.AttackLevel = rng.Next(0, 121);
            player.DefenceLevel = rng.Next(0, 121);
            player.CookingLevel = rng.NextDouble();
            player.Race = (Race) rng.Next(0, 4);
        }

        public void Greet()
        {
            Console.WriteLine($"Greetings, my name is {UserName} and I am a sworn fighter of {ClanName}!");
        }
        public void DataDump()
        {
            Console.WriteLine($"Username: {UserName} " +
                $"Clan name: {ClanName}. " +
                $"I am a noble {Race} " +
                $"and my levels are: " +
                $"Health-{HealthLevel}, " +
                $"Defence-{DefenceLevel}, " +
                $"Attack-{AttackLevel} " +
                $"and Coocking-{CookingLevel}");
        }
    }
}
