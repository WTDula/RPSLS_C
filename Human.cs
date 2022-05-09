using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public static int ChooseGesture()
        {
            int input;
            Console.WriteLine("Select the number of your gesture for player 2: ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
