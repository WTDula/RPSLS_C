using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public static int ChooseGesture()
        {
            Random rnd = new();
            int aiChoice = rnd.Next(0, 5);
            return aiChoice;
        }
        
    }
}
