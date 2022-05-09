using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public string[] gestures;
        public int score;

        public Human()
        {
            this.gestures = new string[5];
            this.gestures[0] = "Rock";
            this.gestures[1] = "Paper";
            this.gestures[2] = "Scissors";
            this.gestures[3] = "Lizard";
            this.gestures[4] = "Spock";
            this.score = 0;
        }
        public override int ChooseGesture()
        {
            Console.WriteLine("Select the number of your gesture for player 2: ");
            int input = Int32.Parse(Console.ReadLine());
            return input;
        }
    }
}
