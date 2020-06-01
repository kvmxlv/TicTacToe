using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.ResetColor();

            string title =
                @"
                               
                ╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐  ┌┬┐┬┌─┐ ┌┬┐┌─┐┌─┐ ┌┬┐┌─┐┌─┐  ╔═╗ ─┼─┼─ ┌─┐┌─┐┌┬┐┌─┐ 
                ║║║├┤ │  │  │ ││││├┤    │ │ │   │ ││    │ │─|│    │ │ │├┤   ║   ─┼─┼─ │ _│─|│││├┤
                ╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘   ┴ ┴└─┘  ┴ └ ┘└─┘  ┴ └─┘└─┘  ╚═╝       └─┘└ ┘┴ ┴└─┘

                ";

            Console.WriteLine(title);
                                          
            Console.WriteLine("                 ╔════════════════════════════════════════════╗      ");
            Console.WriteLine("                 ║                    <MENU>                  ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");
            Console.WriteLine("                 ║         <Press a number to choose>         ║      ");
            Console.WriteLine("                 ║                                            ║      ");
            Console.WriteLine("                 ║           -1- Start a new game             ║      ");
            Console.WriteLine("                 ║           -2- Exit                         ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");


            Console.WriteLine("                 ╔══════════════════════════════════════════════════════╗    ");
            Console.WriteLine("                 ║                       <RULES>                        ║    ");
            Console.WriteLine("                 ╚══════════════════════════════════════════════════════╝    ");
            Console.WriteLine("                 ║It's a game for 2 players. First player plays with X  ║    ");
            Console.WriteLine("                 ║and the second one plays with O. We have a board      ║    ");
            Console.WriteLine("                 ║consisting of a 3X3 grid. Only one player can play at ║    ");
            Console.WriteLine("                 ║a time. If the square is filled we cannot override it.║    ");
            Console.WriteLine("                 ║When a player place 3 of his special character in a   ║    ");
            Console.WriteLine("                 ║horizontal, vertical or diagonal row he wins the game.║    ");
            Console.WriteLine("                 ║                                                      ║    ");
            Console.WriteLine("                 ║                                                      ║    ");
            Console.WriteLine("                 ╚══════════════════════════════════════════════════════╝    ");
        }




        static void Main(string[] args)
        {
            Menu();

            
        }
    }
}
