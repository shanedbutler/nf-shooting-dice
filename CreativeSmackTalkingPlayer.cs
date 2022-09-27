using System;
using System.Collections.Generic;
using System.Linq;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> taunts = new List<string>()
        {
            "If I were you I'd QUIT",
            "Face me and LOSE",
            "I bet you can't WIN",
            "Why you ought to STEP BACK",
            "I'm gonna roll you OUT",
            "Dice is my LIFE"
        };
        private string Taunt()
        {
            int randomI = new Random().Next(0, taunts.Count());
            return taunts[randomI];
        }
        public override int Roll()
        {
            Console.WriteLine($"{this.Name} says \"{Taunt()}\"");
            return base.Roll();
        }
    }
}