using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            this.Game = new Board(3, 4, 6);
            this.P1 = new Player("Thien An");
            this.P2 = new Player("Phuong Linh");
        }

        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                Console.WriteLine(P1.GetName() + " play");
                P1.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine("P1 game over");
                    break;
                }
                Console.WriteLine(P2.GetName() + " play");
                P2.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine("P2 game over");
                    break;
                }
            }
        }
    }
}
