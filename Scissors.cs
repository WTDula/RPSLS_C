using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Scissors : Gesture
    {
        public IDictionary<string, string> winsAgainst;

        public Scissors()
        {
            this.name = "Scissors";
            IDictionary<string, string> wins = new Dictionary<string, string>();
            wins.Add("Paper", "Scissors cuts Paper");
            wins.Add("Lizard", "Scissors decapitates Lizard");
            this.winsAgainst = wins;

        }
        public override bool DoIWin(Gesture otherGesture)
        {
            if (winsAgainst.ContainsKey(otherGesture.name))
            {
                Console.WriteLine(this.winsAgainst[otherGesture.name]);
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
