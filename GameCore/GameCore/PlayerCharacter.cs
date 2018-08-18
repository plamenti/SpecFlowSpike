using System;

namespace GameCore
{
    public class PlayerCharacter
    {
        public int Health { get; set; } = 100;
        public bool IsDead { get; set; }
        public int DamageResistance { get; set; }
        public string Race { get; set; }
        
        public void Hit(int damage)
        {
            int raceSpecificResistance = 0;

            if (Race == "Elf")
            {
                raceSpecificResistance = 20;
            }

            int totalDamageTaken = Math.Max(damage - raceSpecificResistance - DamageResistance, 0);

            Health -= totalDamageTaken;

            if (Health <= 0)
            {
                IsDead = true;
            }
        }
    }
}
