using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class GameObj
    {
        Gesture[] RPSLSArray;

        public GameObj()
        {
            this.RPSLSArray = new Gesture[5];
        }

        public void CreateGameObj()
        {
            this.RPSLSArray[0] = new Rock();
            this.RPSLSArray[1] = new Paper();
            this.RPSLSArray[2] = new Scissors();
            this.RPSLSArray[3] = new Lizard();
            this.RPSLSArray[4] = new Spock();
        }
    }
}
