﻿using System;
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
            Console.WriteLine("Select the number of your gesture for player 2: ");
            int input = Int32.Parse(Console.ReadLine());
            return input;
        }
    }
}
