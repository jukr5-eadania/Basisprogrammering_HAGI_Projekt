using Chess;
using Game_Jeopardy_Emilie;
using Julius_MineSweeper;
using System;

namespace MainMenu
{
    internal class Menu
    {
        static int Selected = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                DrawMenu();
                // Does an action depending on user input
                switch (Console.ReadKey().Key)
                {
                    // Moves arrow up
                    case ConsoleKey.UpArrow:
                        {
                            if (Selected > 1)
                            {
                                Selected--;
                            }
                            break;
                        }
                    // Moves arrow down
                    case ConsoleKey.DownArrow:
                        {
                            if (Selected < 3)
                            {
                                Selected++;
                            }
                            break;
                        }
                    // Exits program
                    case ConsoleKey.Escape:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    // Starts the game the arrow is pointing to
                    case ConsoleKey.Enter:
                        {
                            switch (Selected)
                            {
                                case 1:
                                    {
                                        ChessGame.PlayChess();
                                        break;
                                    }

                                case 2:
                                    {
                                        MineSweeper.PlayMineSweeper();
                                        break;
                                    }

                                case 3:
                                    {
                                        JeopardyProg.PlayJeopardy();
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
        }

        static void DrawMenu()
        {
            // Draws options with an arrow
            Console.Clear();
            if (Selected == 1)
            {
                Console.WriteLine("Mads - Chess <-");
                Console.WriteLine("Julius - MineSweeper");
                Console.WriteLine("Emilie - Jeopardy");
            }
            else if (Selected == 2)
            {
                Console.WriteLine("Mads - Chess");
                Console.WriteLine("Julius - MineSweeper <-");
                Console.WriteLine("Emilie - Jeopardy");
            }
            else if (Selected == 3)
            {
                Console.WriteLine("Mads - Chess");
                Console.WriteLine("Julius - MineSweeper");
                Console.WriteLine("Emilie - Jeopardy <-");
            }
        }
    }
}
