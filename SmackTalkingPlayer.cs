using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        private string taunt = "I'm gonna grind you into DUST!";
        public override int Roll()
        {
            Console.WriteLine($"{this.Name} says \"{this.taunt}\"");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;

        }
    }

}