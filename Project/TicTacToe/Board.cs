﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        public static char[] Array = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //array that stores the players input 


        public static void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", Array[0], Array[1], Array[2]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", Array[3], Array[4], Array[5]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", Array[6], Array[7], Array[8]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
        }

        public static void ResetGame()
        {
            char[] NewArray = { '1', '2', '3','4', '5', '6','7', '8', '9' }; //array to reset the board

            Array = NewArray;
            PrintBoard();
            Game.turns = 0;
        }

    }
}
