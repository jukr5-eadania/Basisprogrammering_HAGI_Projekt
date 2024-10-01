using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Julius_MineSweeper
{
    //Defines enums used to reprecent spaces on the board with numbers
    enum Spaces
    {
        Unkown,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Bomb,
        EmptySpace,
        Flag
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
        static int flags = 10;
        static string gameStart = "y";

        static void Main(string[] args)
        {
            while (gameStart == "y")
            {
                CreateNewMSB();
                Console.WriteLine("Welcome to MineSweeper");
                playing = true;

                while (playing)
                {
                    Console.Clear();
                    Console.WriteLine("Flags: " + flags);
                    WritePlayerMSB();
                    CheckMSBValue();
                }
                Console.WriteLine("Wanna play again? (y/n)");
                gameStart = Console.ReadLine();
            }

        }

        /// <summary>
        /// Creates a new MineSweeper board
        /// </summary>
        static void CreateNewMSB()
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

        }

        /// <summary>
        /// Writes the MSB that the player will see during play
        /// </summary>
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
                    if (playerMSB[x, y] == (int)Spaces.Unkown)
                    {
                        Console.Write("? ");
                        Console.Write("| ");

                    }
                    else if (playerMSB[x, y] == (int)Spaces.Flag)
                    {
                        Console.Write("F ");
                        Console.Write("| ");
                    }
                    else
                    {
                        if (playerMSB[x, y] == (int)Spaces.EmptySpace)
                        {
                            Console.Write("  ");
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write(playerMSB[x, y] + " ");
                            Console.Write("| ");

                        }

                    }

                }
                Console.WriteLine();

            }
            Console.WriteLine("  * - * - * - * - * - * - * - * - *");
        }

        /// <summary>
        /// Writes the MSB created in CreateNewMSB (Mainly used for testing
        /// </summary>
        static void WriteNewMSB()
        {
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
                    if (newMSB[x, y] != (int)Spaces.Unkown)
                    {
                        Console.Write(newMSB[x, y] + " ");
                        Console.Write("| ");

                    }
                    else
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
            //Assign variables
            char[] userInput = Console.ReadLine().ToCharArray();
            int userX = (int)char.GetNumericValue(userInput[0]);
            int userY = (int)char.GetNumericValue(userInput[1]);
            bool flag = false;

            foreach (char character in userInput)
            {
                if (character == 'f')
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                if (playerMSB[userX, userY] == (int)Spaces.Flag)
                {
                    playerMSB[userX, userY] = (int)Spaces.Unkown;
                    flags++;
                }
                else
                {
                    playerMSB[userX, userY] = (int)Spaces.Flag;
                    flags--;
                }
            }
            else
            {
                //Checks if player doens't hit a bomb
                if (newMSB[userX, userY] != (int)Spaces.Bomb)
                {
                    //Checks if the player hits an unknown space
                    if (newMSB[userX, userY] == (int)Spaces.Unkown)
                    {
                        //Changes the spot the player hit to an empty space on the player board
                        playerMSB[userX, userY] = (int)Spaces.EmptySpace;

                        //Checks the 8 surrounding spaces if they are unknown as well and changes them to empty spaces if they are unkown
                        if (newMSB[userX - 1, userY - 1] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX - 1, userY - 1] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX, userY - 1] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX, userY - 1] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX + 1, userY - 1] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX + 1, userY - 1] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX - 1, userY] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX - 1, userY] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX + 1, userY] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX + 1, userY] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX - 1, userY + 1] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX - 1, userY + 1] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX, userY + 1] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX, userY + 1] = (int)Spaces.EmptySpace;
                        }
                        if (newMSB[userX + 1, userY + 1] == (int)Spaces.Unkown)
                        {
                            playerMSB[userX + 1, userY + 1] = (int)Spaces.EmptySpace;
                        }

                    }
                    //Changes playerboard to reflect how the newMSB looks so the player can see what number they revealed
                    else
                    {
                        playerMSB[userX, userY] = newMSB[userX, userY];
                    }

                }
                //If player hits a bomb end the game and write game over
                else
                {
                    Console.Clear();
                    WriteNewMSB();
                    Console.WriteLine("Game Over");
                    playing = false;

                }

            }

        }


    }

}

