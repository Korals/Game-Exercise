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

        public void StatSet(string userName, string clanName)
        {
            var rng = new Random();

            UserName = userName;
            ClanName = clanName;
            HealthLevel = rng.Next(0, 121);
            AttackLevel = rng.Next(0, 121);
            DefenceLevel = rng.Next(0, 121);
            CookingLevel = rng.NextDouble();
            Race = (Race) rng.Next(0, 4);
        }

        public void Greet()
        {
            Console.WriteLine($"Greetings, my name is {UserName} and I am a sworn fighter of {ClanName}!");
        }
        public void DataDump()
        {
            Console.WriteLine($"{nameof(UserName)}: {UserName} | {nameof(ClanName)}: {ClanName}\n" +
                $"A noble {Race}\n" +
                $"Levels:\n" +
                $"{nameof(HealthLevel)}-{HealthLevel}\n" +
                $"{nameof(DefenceLevel)}-{DefenceLevel}\n" +
                $"{nameof(AttackLevel)}-{AttackLevel}\n" +
                $"{nameof(CookingLevel)}-{CookingLevel}.");
        }

        public void SetCookingTo(double change)
        {
            var minCooking = 0.00d;
            var maxCooking = 1.00d;
            var num = change - CookingLevel;
            if (num > 0)
            {
                if (CookingLevel < maxCooking)
                {
                    if (CookingLevel + num < maxCooking)
                        CookingLevel += num;
                    else
                        CookingLevel = maxCooking;
                }
            }
            else
            {
                if (CookingLevel > minCooking)
                {
                    if (CookingLevel + num > minCooking)
                        CookingLevel += num;
                    else
                        CookingLevel = minCooking;
                }
            }
        }

        public void IncreaseLevelsBy(int increase)
        {
            var maxCombat = 121;

            if (HealthLevel < maxCombat)
            {
                if (HealthLevel + increase < maxCombat)
                    HealthLevel += increase;
                else
                    HealthLevel = maxCombat;
            }

            if (DefenceLevel < maxCombat)
            {
                if (DefenceLevel + increase < maxCombat)
                    DefenceLevel += increase;
                else
                    DefenceLevel = maxCombat;
            }

            if (AttackLevel < maxCombat)
            {
                if (AttackLevel + increase < maxCombat)
                    AttackLevel += increase;
                else
                    AttackLevel = maxCombat;
            }
        }

        public void DecreaseLevelsBy(int decrease)
        {
            var minCombat = 0;

            if (HealthLevel > minCombat)
            {
                if (HealthLevel - decrease > minCombat)
                    HealthLevel -= decrease;
                else
                    HealthLevel = minCombat;
            }

            if (DefenceLevel > minCombat)
            {
                if (DefenceLevel - decrease > minCombat)
                    DefenceLevel -= decrease;
                else
                    DefenceLevel = minCombat;
            }

            if (AttackLevel > minCombat)
            {
                if (AttackLevel - decrease > minCombat)
                    AttackLevel -= decrease;
                else
                    AttackLevel = minCombat;
            }
        }
    }
}
