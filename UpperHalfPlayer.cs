using System;
namespace ShootingDice
{

    // A Player whose roll will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int roll = new Random().Next(DiceSize) + 1;
            if (roll <=3 )
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