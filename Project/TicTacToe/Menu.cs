using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Menu
    {
        public static void Title()
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
            Console.WriteLine();

            Console.WriteLine("Press any key to display menu");
            Console.ReadKey();
            Console.WriteLine();
            Menu1();

        }

        public static void Menu1()
        {
            Console.Clear();
            Console.WriteLine("                 ╔════════════════════════════════════════════╗      ");
            Console.WriteLine("                 ║                    <MENU>                  ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");
            Console.WriteLine("                 ║         <Press a number to choose>         ║      ");
            Console.WriteLine("                 ║                                            ║      ");
            Console.WriteLine("                 ║           -1- Start a new game             ║      ");
            Console.WriteLine("                 ║           -2- Exit                         ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");
            Console.WriteLine();

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Board.PrintBoard();
                    break;

                case 2:
                    ExitQuestion();
                    break;
            }
        }

        public static void ExitQuestion()
        {
            Console.Clear();
            Console.WriteLine("                 ╔════════════════════════════════════════════╗      ");
            Console.WriteLine("                 ║   ARE YOU SURE U WANT TO QUIT GAME? :(     ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");
            Console.WriteLine("                 ║         <Press a number to choose>         ║      ");
            Console.WriteLine("                 ║                                            ║      ");
            Console.WriteLine("                 ║                  -1- Yes                   ║      ");
            Console.WriteLine("                 ║                  -2- No                    ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Environment.Exit(0);
                    break;

                case 2:
                    Menu1();
                    break;
            }

        }
    }
}
