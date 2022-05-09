using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Paper : Gesture
    {
        public IDictionary<string, string> winsAgainst;
        public Paper()
        {
            this.name = "Paper";
            IDictionary<string, string> wins = new Dictionary<string, string>();
            wins.Add("Rock", "Paper covers Rock");
            wins.Add("Spock", "Paper disproves Spock");
            this.winsAgainst = wins;
        }

        public override bool DoIWin(Gesture otherGesture)
        {
            if(winsAgainst.ContainsKey(otherGesture.name))
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
