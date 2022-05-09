using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Spock : Gesture
    {
        public IDictionary<string, string> winsAgainst;

        public Spock()
        {
            this.name = "Spock";
            IDictionary<string, string> wins = new Dictionary<string, string>();
            wins.Add("Scissors", "Spock smashes Scissors");
            wins.Add("Rock", "Spock vaporizes Rock");
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
