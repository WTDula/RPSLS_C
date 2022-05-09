using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        public Player player1;
        public Player player2;
        public GameObj gameObj;
        public bool isSinglePlayer;

        public Game()
        {
            this.player1 = new Human();
            this.player2 = new AI();
            this.gameObj = new GameObj();
            this.isSinglePlayer = false;
        }

    }
}
