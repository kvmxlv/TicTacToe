using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu.Title();

            do //player 1 starts
            {
                if (Game.player == 1)
                {
                    Game.player = 2;
                    
                }
                else if (Game.player == 2)
                {
                    Game.player = 1;
                    
                }

                Board.PrintBoard();
                Game.turns++;

            } while (true);




        }
    }
}
