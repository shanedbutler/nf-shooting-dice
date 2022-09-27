using System;
namespace ShootingDice
{
    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int roll;
            while (true)
            {
                Console.WriteLine($"{this.Name}, enter the number you wish to roll");
                string input = Console.ReadLine();

                bool success = int.TryParse(input, out int parsed);
                if (parsed > 6 || parsed < 1 && success == true)
                {
                    Console.WriteLine($"{input} is not in the range of six-sided dice");
                    continue;
                }
                else if (success)
                {
                    roll = parsed;
                    break;
                }
                else if (input == "")
                {
                    Console.WriteLine("You forgot to enter a number!");
                    continue;
                }
                else
                {
                    Console.WriteLine($"\"{input}\" is not a valid entry!");
                    continue;
                }
            }
            return roll;
        }
    }
}