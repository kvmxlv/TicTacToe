﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        public static int turns = 0;
        public static int player = 2;
        public static int input = 0;
        public static bool inputOk = true;
        public static char symbol = ' ';



        public static void Gameplay() 
        {

            do //player 1 starts
            {
                if (player == 2)
                {
                    player = 1;
                    WhichSymbol(player, input);

                }
                else if (player == 1)
                {
                    player = 2;
                    WhichSymbol(player, input);
                }

               
                Board.PrintBoard();
                turns++;


                //check if someone won the game
                CheckHorizontal();
                CheckVertical();
                CheckDiagonal();


                if (turns > 9)
                {
                    EndGame();
                }

                    do
                {
                    Console.WriteLine();
                    Console.WriteLine("Player {0} turn ! ", player);
                    Console.WriteLine("Enter position 1-9");

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    } 
                    catch
                    {
                        Console.WriteLine("Hey, it's not a number ! I said enter 1-9, try again.");
                    }


                    if ((input == 1) && (Board.Array[0] == '1'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 2) && (Board.Array[1] == '2'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 3) && (Board.Array[2] == '3'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 4) && (Board.Array[3] == '4'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 5) && (Board.Array[4] == '5'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 6) && (Board.Array[5] == '6'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 7) && (Board.Array[6] == '7'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 8) && (Board.Array[7] == '8'))
                    {
                        inputOk = true;
                    }
                    else if ((input == 9) && (Board.Array[8] == '9'))
                    {
                        inputOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not possible to do it :( ");
                        inputOk = false;
                    }

                } while (!inputOk);

            } while (true);
        }

        public static void CheckHorizontal()
        {
            List<char> symbols = new List<char>();
            symbols.Add('X');
            symbols.Add('O');

            foreach (char symbol in symbols)
            {
                if (((Board.Array[0] == symbol) && (Board.Array[1] == symbol) && (Board.Array[2] == symbol)) || ((Board.Array[3] == symbol) && (Board.Array[4] == symbol) && (Board.Array[5] == symbol))|| ((Board.Array[6] == symbol) && (Board.Array[7] == symbol) && (Board.Array[8] == symbol)))
                {   
                    
                    if (symbol == 'X')
                    {
                        Console.Clear();
                        Console.WriteLine("        ============================================        ");
                        Console.WriteLine("                         <GAME OVER>                        ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                        Player 1 won.                       ");
                        Console.WriteLine("                 Congratulations, it took you               ");
                        Console.WriteLine("                 {0} turns to achieve it ! :)", turns        );
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                  <Press a number to choose>                ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                     -1- Play again                         ");
                        Console.WriteLine("                     -2- Go to main menu                    ");
                        Console.WriteLine("        ============================================        ");

                    }
                    else if (symbol == 'O')
                    {
                        Console.Clear();
                        Console.WriteLine("        ============================================        ");
                        Console.WriteLine("                         <GAME OVER>                        ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                        Player 2 won.                       ");
                        Console.WriteLine("                 Congratulations, it took you               ");
                        Console.WriteLine("                 {0} turns to achieve it ! :)", turns);
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                  <Press a number to choose>                ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                     -1- Play again                         ");
                        Console.WriteLine("                     -2- Go to main menu                    ");
                        Console.WriteLine("        ============================================        ");
                    }

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Board.ResetGame();
                            break;

                        case 2:
                            Board.ResetGame();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Menu.MainMenu();
                            break;
                    }

                    break;
                }
            }
        }

        public static void CheckVertical()
        {
            List<char> symbols = new List<char>();
            symbols.Add('X');
            symbols.Add('O');

            foreach (char symbol in symbols)
            {
                if (((Board.Array[0] == symbol) && (Board.Array[3] == symbol) && (Board.Array[6] == symbol)) || ((Board.Array[1] == symbol) && (Board.Array[4] == symbol) && (Board.Array[7] == symbol)) || ((Board.Array[2] == symbol) && (Board.Array[5] == symbol) && (Board.Array[8] == symbol)))
                {

                    if (symbol == 'X')
                    {
                        Console.Clear();
                        Console.WriteLine("        ============================================        ");
                        Console.WriteLine("                         <GAME OVER>                        ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                        Player 1 won.                       ");
                        Console.WriteLine("                 Congratulations, it took you               ");
                        Console.WriteLine("                 {0} turns to achieve it ! :)", turns);
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                  <Press a number to choose>                ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                     -1- Play again                         ");
                        Console.WriteLine("                     -2- Go to main menu                    ");
                        Console.WriteLine("        ============================================        ");

                    }
                    else if (symbol == 'O')
                    {
                        Console.Clear();
                        Console.WriteLine("        ============================================        ");
                        Console.WriteLine("                         <GAME OVER>                        ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                        Player 2 won.                       ");
                        Console.WriteLine("                 Congratulations, it took you               ");
                        Console.WriteLine("                 {0} turns to achieve it ! :)", turns);
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                  <Press a number to choose>                ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                     -1- Play again                         ");
                        Console.WriteLine("                     -2- Go to main menu                    ");
                        Console.WriteLine("        ============================================        ");
                    }

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Board.ResetGame();
                            break;

                        case 2:
                            Board.ResetGame();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Menu.MainMenu();
                            break;
                    }

                    break;
                }
            }
        }

        public static void CheckDiagonal()
        {
            List<char> symbols = new List<char>();
            symbols.Add('X');
            symbols.Add('O');

            foreach (char symbol in symbols)
            {
                if (((Board.Array[0] == symbol) && (Board.Array[4] == symbol) && (Board.Array[8] == symbol)) || ((Board.Array[6] == symbol) && (Board.Array[4] == symbol) && (Board.Array[2] == symbol)))
                {

                        if (symbol == 'X')
                    {
                        Console.Clear();
                        Console.WriteLine("        ============================================        ");
                        Console.WriteLine("                         <GAME OVER>                        ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                        Player 1 won.                       ");
                        Console.WriteLine("                 Congratulations, it took you               ");
                        Console.WriteLine("                 {0} turns to achieve it ! :)", turns);
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                  <Press a number to choose>                ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                     -1- Play again                         ");
                        Console.WriteLine("                     -2- Go to main menu                    ");
                        Console.WriteLine("        ============================================        ");

                    }
                    else if (symbol == 'O')
                    {
                        Console.Clear();
                        Console.WriteLine("        ============================================        ");
                        Console.WriteLine("                         <GAME OVER>                        ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                        Player 2 won.                       ");
                        Console.WriteLine("                 Congratulations, it took you               ");
                        Console.WriteLine("                 {0} turns to achieve it ! :)", turns);
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                  <Press a number to choose>                ");
                        Console.WriteLine("                                                            ");
                        Console.WriteLine("                     -1- Play again                         ");
                        Console.WriteLine("                     -2- Go to main menu                    ");
                        Console.WriteLine("        ============================================        ");
                    }

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Board.ResetGame();
                            break;

                        case 2:
                            Board.ResetGame();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Menu.MainMenu();
                            break;
                    }

                    break;
                }
            }
        }

        public static void WhichSymbol(int player, int input)
        {
            //check if player X or O takes turn

            if (player == 1)
            {
                symbol = 'O';

            }
            else if (player == 2)
            {
                symbol = 'X';
            }

            switch (input)
            {
                case 1:
                    Board.Array[0] = symbol;
                    break;
                case 2:
                    Board.Array[1] = symbol;
                    break;
                case 3:
                    Board.Array[2] = symbol;
                    break;
                case 4:
                    Board.Array[3] = symbol;
                    break;
                case 5:
                    Board.Array[4] = symbol;
                    break;
                case 6:
                    Board.Array[5] = symbol;
                    break;
                case 7:
                    Board.Array[6] = symbol;
                    break;
                case 8:
                    Board.Array[7] = symbol;
                    break;
                case 9:
                    Board.Array[8] = symbol;
                    break;
            }
        }

        public static void EndGame()
        { 
                //method is called when there is more than 9 turns, it ends game without any winner

                Console.Clear();
                Console.WriteLine("        ============================================        ");
                Console.WriteLine("                         <GAME OVER>                        ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                 It's a {0}th turn already,", turns);                 
                Console.WriteLine("                 sorry, you cannot play more than 9.        ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                  <Press a number to choose>                ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                     -1- Play again                         ");
                Console.WriteLine("                     -2- Go to main menu                    ");
                Console.WriteLine("        ============================================        ");
            

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Board.ResetGame();
                    break;

                case 2:
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Menu.MainMenu();
                    break;
            } 
        } 



    }
}
