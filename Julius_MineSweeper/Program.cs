using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Julius_MineSweeper
{
    //Defines enums used to reprecent spaces on the board with numbers
    enum Spaces
    {
        EmptySpace,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Bomb
    }

    internal class Program
    {
        //Define variables and arrays
        static Random rnd = new Random();
        static int[,] newMSB = new int[10, 10];
        static int[,] playerMSB = new int[10, 10];
        static int[] sideGrid = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        static int sideGridNumber = 0;
        static string userInput = string.Empty;
        static bool playing = true;

        static void Main(string[] args)
        {
            //Define variables


            WriteNewMSB();
            Console.WriteLine("Welcome to MineSweeper");

            while (playing)
            {
                WritePlayerMSB();
                CheckMSBValue();
            }
            Console.WriteLine("The program will now terminate");
            Thread.Sleep(1000);
        }

        static void WritePlayerMSB()
        {
            sideGridNumber = 0;
            Console.WriteLine("PlayerMSB");
            Console.WriteLine("    1   2   3   4   5   6   7   8");

            for (int y = 1; y < playerMSB.GetLength(0) - 1; y++)
            {
                Console.WriteLine("  * - * - * - * - * - * - * - * - *");
                Console.Write(sideGrid[sideGridNumber] + " | ");
                sideGridNumber++;
                for (int x = 1; x < playerMSB.GetLength(1) - 1; x++)
                {
                    Console.Write(playerMSB[x, y] + " ");
                    Console.Write("| ");

                }
                Console.WriteLine();

            }
            Console.WriteLine("  * - * - * - * - * - * - * - * - *");
        }

        /// <summary>
        /// Creates a new MineSweeper board
        /// </summary>
        static void WriteNewMSB()
        {
            //For loop that places 10 bombs in random spaces on the array
            for (int a = 0; a < 11; a++)
            {
                int rndX = rnd.Next(1, 9);
                int rndY = rnd.Next(1, 9);
                newMSB[rndX, rndY] = (int)Spaces.Bomb;
            }

            //For loop that loops through all numbers on the array to check for bombs in the surrounding 8 fields of the field its currently on
            //and assigns a number to that field based on it
            for (int y = 1; y < newMSB.GetLength(0) - 1; y++)
            {
                for (int x = 1; x < newMSB.GetLength(1) - 1; x++)
                {
                    if (newMSB[x, y] != (int)Spaces.Bomb)
                    {
                        int bombs = 0;
                        if (newMSB[x - 1, y - 1] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x, y - 1] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x + 1, y - 1] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x - 1, y] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x + 1, y] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x - 1, y + 1] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x, y + 1] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        if (newMSB[x + 1, y + 1] == (int)Spaces.Bomb)
                        {
                            bombs++;
                        }
                        newMSB[x, y] = (int)((Spaces)bombs);
                    }

                }

            }

            //Writes the new MS board(Mainly used for testing if if the function works)
            sideGridNumber = 0;
            Console.WriteLine("NewMSB");
            Console.WriteLine("    1   2   3   4   5   6   7   8");
            for (int y = 1; y < newMSB.GetLength(0) - 1; y++)
            {
                Console.WriteLine("  * - * - * - * - * - * - * - * - *");
                Console.Write(sideGrid[sideGridNumber] + " | ");
                sideGridNumber++;
                for (int x = 1; x < newMSB.GetLength(1) - 1; x++)
                {
                    if (newMSB[x, y] != (int)Spaces.EmptySpace)
                    {
                        Console.Write(newMSB[x, y] + " ");
                        Console.Write("| ");

                    } else
                    {
                        Console.Write("  ");
                        Console.Write("| ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine("  * - * - * - * - * - * - * - * - *");
        }

        /// <summary>
        /// Checks MSB based on user input
        /// </summary>
        static void CheckMSBValue()
        {
            char[] userInput = Console.ReadLine().ToCharArray();
            int userX = (int)char.GetNumericValue(userInput[0]);
            int userY = (int)char.GetNumericValue(userInput[1]);
            int userPosition = newMSB[userX, userY];

            if (newMSB[userX, userY] != (int)Spaces.Bomb)
            {
                Console.WriteLine(userPosition);
                playerMSB[userX, userY] = newMSB[userX, userY];

            }
            else
            {
                Console.WriteLine("Game Over");
                playing = false;

            }

        }

    }

}
