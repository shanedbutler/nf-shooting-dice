using System;
namespace ShootingDice
{
    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
        public override int Roll()
        {
            int roll = new Random().Next(DiceSize) + 1;
            if (roll <= 3)
            {
                return (roll + 3);
            }
            else
            {
                return roll;
            }
        }
    }
}