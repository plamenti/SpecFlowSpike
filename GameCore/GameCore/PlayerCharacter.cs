using System;
using System.Collections.Generic;
using System.Linq;

namespace GameCore
{
    public class PlayerCharacter
    {
        public int Health { get; set; } = 100;
        public bool IsDead { get; set; }
        public int DamageResistance { get; set; }
        public string Race { get; set; }
        public int MagicPower
        {
            get
            {
                return MagicalItems.Sum(x => x.Power);
            }
        }

        public List<MagicalItem> MagicalItems { get; set; }
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public CharacterClass CharacterClass { get; set; }
        public DateTime LastSleepTime { get; set; }
        public int WeaponsValue
        {
            get
            {
                return Weapons.Sum(x => x.Value);
            }
        }

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

        public void CastHealingSpell()
        {
            if (CharacterClass == CharacterClass.Healer)
            {
                Health = 100;
            }
            else
            {
                Health += 10;
            }
        }

        public void ReadHealthScroll()
        {
            int daysSinceLastSleep = DateTime.Now.Subtract(LastSleepTime).Days;
            if (daysSinceLastSleep <= 2)
            {
                Health = 100;
            }
        }

        public void UseMagicalItem(string itemName)
        {
            int powerReduction = 10;
            if(Race == "Elf")
            {
                powerReduction = 0;
            }

            MagicalItem itemToReduce = MagicalItems.First(item => item.Name == itemName);
            itemToReduce.Power -= powerReduction;
        }
    }
}
