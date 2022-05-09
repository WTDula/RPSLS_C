using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Rock : Gesture
    {
        public IDictionary<string, string> winsAgainst;
        public Rock()
        {
            this.name = "Rock";
            IDictionary<string, string> wins = new Dictionary<string, string>();
            wins.Add("Lizard", "Rock crushes Lizard");
            wins.Add("Scissors", "Rock crushes Scissors");
            this.winsAgainst = wins;
        }
    }
}
