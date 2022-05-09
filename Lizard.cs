using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Lizard : Gesture
    {
        public IDictionary<string, string> winsAgainst;
        public Lizard()
        {
            this.name = "Lizard";
            IDictionary<string, string> wins = new Dictionary<string, string>();
            wins.Add("Spock", "Lzard poisons Spock");
            wins.Add("Paper", "Lizard eats Paper");
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
