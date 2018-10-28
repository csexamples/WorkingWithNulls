using System;

namespace GameConsole
{
    public class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }

        public int? DaysSinceLastLogin { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? IsNew { get; set; }

        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            Health -= damage - _specialDefence.CalculateDamageReduction(damage);

            Console.WriteLine($"Player's {Name} health has been decreased by {damage} and it's now {Health}.");
        }
    }
}
