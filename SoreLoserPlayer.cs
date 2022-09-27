using System;
namespace ShootingDice
{

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            try
            {

                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                    Console.WriteLine($"{this.Name} says \"I will NOT lose!\"");
                    Console.WriteLine($"{this.Name} throws an exception");
                    throw new Exception($"{this.Name} says \"I don't lose\"");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("The ref handles the exception");
                Console.WriteLine("\"No sore losers!\"");
            }
        }
    }
}