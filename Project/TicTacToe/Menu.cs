using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Menu
    {

        public enum BoardColor
        {
            Cyan,
            Red,
            Yellow,
            Green,
            Magenta
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;

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
            MainMenu();

        }

        public static void MainMenu()
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
                    ChooseColor();
                    break;

                case 2:
                    ExitQuestion();
                    break;
                default:
                    TryAgain();
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
                    MainMenu();
                    break;
                default:
                    TryAgain();
                    break;
            }

        }

        public static void ChooseColor()
        {
            Console.Clear();
            Console.WriteLine("                  ╔════════════════════════════════════════════╗      ");
            Console.WriteLine("                  ║    <Before we start choose board color>    ║      ");
            Console.WriteLine("                  ╚════════════════════════════════════════════╝      ");
            Console.WriteLine("                  ║          <Press a number to choose>        ║      ");
            Console.WriteLine("                  ║                                            ║      ");
            Console.WriteLine($"                  ║                 -1- {BoardColor.Cyan}                   ║      ");
            Console.WriteLine($"                  ║                 -2- {BoardColor.Red}                    ║      ");
            Console.WriteLine($"                  ║                 -3- {BoardColor.Yellow}                 ║      ");
            Console.WriteLine($"                  ║                 -4- {BoardColor.Green}                  ║      ");
            Console.WriteLine($"                  ║                 -5- {BoardColor.Magenta}                ║      ");
            Console.WriteLine("                  ╚════════════════════════════════════════════╝      ");

            
           
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Game.Gameplay();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Game.Gameplay();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Game.Gameplay();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Game.Gameplay();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Game.Gameplay();
                    break;
                default:
                    TryAgain();
                    break;
            }
        }

        public static void TryAgain()
        {
            Console.Clear();
            Console.WriteLine("                 ╔════════════════════════════════════════════╗      ");
            Console.WriteLine("                 ║                      OOPS                  ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");
            Console.WriteLine("                 ║        Option not available.               ║      ");
            Console.WriteLine("                 ║        Choose correct number next time.    ║      ");
            Console.WriteLine("                 ║        Press any key to try again.         ║      ");
            Console.WriteLine("                 ╚════════════════════════════════════════════╝      ");


            Console.ReadKey();
            MainMenu();
        
        }
            
        
    }
}

