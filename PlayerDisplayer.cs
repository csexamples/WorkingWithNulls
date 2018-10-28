using System;

namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("There's no player name provided or it's all whitespace.");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            int daysSinceLastLogin = player.DaysSinceLastLogin ?? -1;

            //int daysSinceLastLogin = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            Console.WriteLine($"{daysSinceLastLogin} days since last login.");

            if (player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("There's no date of birth provided.");
            }
            else
            {
                Console.WriteLine($"Date of birth: {player.DateOfBirth}");
            }

            if (player.IsNew == null)
            {
                Console.WriteLine("Player newbie status is unknown.");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is a newbie.");
            }
            else
            {
                Console.WriteLine("Player is experienced.");
            }
        }
    }
}
