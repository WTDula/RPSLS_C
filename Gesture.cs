using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Gesture
    {
        public string name;

        public Gesture()
        {
            this.name = "";
        }

        public abstract bool DoIWin(Gesture otherGesture);
    }
}
