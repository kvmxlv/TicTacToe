using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        public static int turns = 0;
        public static int player = 1;
        public static int input = 0;

        public static void ResetGame()
        {
            Board.Array = Board.NewArray;
            Board.PrintBoard();
            turns = 0;
        }



    }
}
