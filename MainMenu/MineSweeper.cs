﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    internal class MineSweeper
    {
        //Define variables and arrays
        static Random rnd = new Random();
        static int[,] newMSB = new int[8, 8];
        static int[,] playerMSB = new int[8, 8];
        static int[] sideGrid = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        static int sideGridNumber = 0;
        static string userInput = string.Empty;
        static string playing = "n";
        static int flags = 10;
        static string gameStart = "y";
        static bool win;
        static int numUnknownSpaces;
        static int userX;
        static int userY;

        public static void PlayMineSweeper()
        {
            //Intro loop
            gameStart = "y";

            while (gameStart == "y")
            {
                Console.Clear();
                Array.Clear(playerMSB, 0, playerMSB.Length);
                Array.Clear(newMSB, 0, playerMSB.Length);
                CreateNewMSB();
                Console.WriteLine("Welcome to MineSweeper");
                Console.WriteLine("Do you wanna play? (y/n)");
                gameStart = playing = Console.ReadLine();

                //Game loop
                while (playing == "y")
                {
                    Console.Clear();
                    WriteTutorial();
                    WritePlayerMSB();
                    CheckMSBValue();
                    WinCondition();
                }

                //If the player wins
                if (win)
                {
                    Console.Clear();
                    WritePlayerMSB();
                    Console.WriteLine("You Won!");
                    Console.WriteLine("Press Enter to go back to the menu");
                    Console.ReadLine();

                }

            }

        }

        /// <summary>
        /// Creates a new MineSweeper board
        /// </summary>
        static void CreateNewMSB()
        {
            //For loop that places 10 bombs in random spaces on the array
            for (int a = 0; a < 10; a++)
            {
                int rndX = rnd.Next(0, 8);
                int rndY = rnd.Next(0, 8);
                newMSB[rndX, rndY] = (int)Spaces.Bomb;
            }

            //For loop that loops through all numbers on the array to check for bombs in the surrounding 8 fields of the field its currently on
            //and assigns a number to that field based on it
            for (int y = 0; y < newMSB.GetLength(0); y++)
            {
                for (int x = 0; x < newMSB.GetLength(1); x++)
                {
                    if (newMSB[x, y] != (int)Spaces.Bomb)
                    {
                        int bombs = 0;
                        try
                        {
                            if (newMSB[x - 1, y - 1] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (newMSB[x, y - 1] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (newMSB[x + 1, y - 1] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (newMSB[x - 1, y] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (newMSB[x + 1, y] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (newMSB[x - 1, y + 1] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (newMSB[x, y + 1] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (newMSB[x + 1, y + 1] == (int)Spaces.Bomb)
                            {
                                bombs++;
                            }
                        }
                        catch
                        {

                        }
                        newMSB[x, y] = (int)((Spaces)bombs);
                        numUnknownSpaces++;
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
            Console.WriteLine("Flags: " + flags);
            Console.WriteLine("    1   2   3   4   5   6   7   8");

            for (int y = 0; y < playerMSB.GetLength(0); y++)
            {
                Console.WriteLine("  * - * - * - * - * - * - * - * - *");
                Console.Write(sideGrid[sideGridNumber] + " | ");
                sideGridNumber++;
                for (int x = 0; x < playerMSB.GetLength(1); x++)
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
            for (int y = 0; y < newMSB.GetLength(0); y++)
            {
                Console.WriteLine("  * - * - * - * - * - * - * - * - *");
                Console.Write(sideGrid[sideGridNumber] + " | ");
                sideGridNumber++;
                for (int x = 0; x < newMSB.GetLength(1); x++)
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
            string userInput = Console.ReadLine();
            if (userInput == "q")
            {
                gameStart = "n";
                playing = "n";
                return;
            }

            char[] userInput2 = userInput.ToCharArray();
            userX = (int)char.GetNumericValue(userInput2[0]) - 1;
            userY = (int)char.GetNumericValue(userInput2[1]) - 1;
            bool flag = false;

            //Checks if user input contains a f for flag
            foreach (char character in userInput)
            {
                if (character == 'f')
                {
                    flag = true;
                }
            }

            //If user input a flag 
            if (flag == true)
            {
                //If a flag is already in the postion user wanted to put a flag it removes it
                if (playerMSB[userX, userY] == (int)Spaces.Flag)
                {
                    playerMSB[userX, userY] = (int)Spaces.Unkown;
                    flags++;
                }
                //If there isn't a flag in the postion the user wanted to put a flag it places a flag
                else
                {
                    playerMSB[userX, userY] = (int)Spaces.Flag;
                    flags--;
                }
            }

            //If user didn't input a flag
            else
            {
                //Checks if player doens't hit a bomb
                if (newMSB[userX, userY] != (int)Spaces.Bomb)
                {
                    //Checks if the player hits an empty space
                    if (newMSB[userX, userY] == (int)Spaces.Unkown)
                    {
                        RemoveEmptySpaces();
                    }

                    //Changes playerboard to reflect how the newMSB looks so the player can see what number they revealed
                    else if (playerMSB[userX, userY] == (int)Spaces.Unkown)
                    {
                        playerMSB[userX, userY] = newMSB[userX, userY];
                        numUnknownSpaces--;
                    }

                }
                //If player hits a bomb end the game and write game over
                else
                {
                    Console.Clear();
                    WriteNewMSB();
                    Console.WriteLine("Game Over");
                    playing = "n";
                    Console.WriteLine("Wanna play again? (y/n)");
                    gameStart = Console.ReadLine();
                }

            }

        }

        /// <summary>
        /// Recursive function that removes all empty spaces when a player hits an empty space
        /// </summary>
        static void RemoveEmptySpaces()
        {
            //Changes the spot the player hit to an empty space on the player board
            Console.Clear();
            WritePlayerMSB();
            if (playerMSB[userX, userY] != (int)Spaces.EmptySpace)
            {
                playerMSB[userX, userY] = (int)Spaces.EmptySpace;
                numUnknownSpaces--;

            }

            //Checks the 8 nearby spots if they haven't been cleared and if they are an empty space
            try
            {
                if (playerMSB[userX - 1, userY - 1] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX - 1, userY - 1] == (int)Spaces.Unkown)
                    {
                        userX -= 1;
                        userY -= 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX, userY - 1] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX, userY - 1] == (int)Spaces.Unkown)
                    {
                        userY -= 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX + 1, userY - 1] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX + 1, userY - 1] == (int)Spaces.Unkown)
                    {
                        userX += 1;
                        userY -= 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX - 1, userY] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX - 1, userY] == (int)Spaces.Unkown)
                    {
                        userX -= 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX + 1, userY] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX + 1, userY] == (int)Spaces.Unkown)
                    {
                        userX += 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX - 1, userY + 1] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX - 1, userY + 1] == (int)Spaces.Unkown)
                    {
                        userX -= 1;
                        userY += 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX, userY + 1] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX, userY + 1] == (int)Spaces.Unkown)
                    {
                        userY += 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

            try
            {
                if (playerMSB[userX + 1, userY + 1] != (int)Spaces.EmptySpace)
                {
                    if (newMSB[userX + 1, userY + 1] == (int)Spaces.Unkown)
                    {
                        userX += 1;
                        userY += 1;
                        RemoveEmptySpaces();
                    }

                }
            }
            catch
            {

            }

        }

        /// <summary>
        /// Checks if the player has won
        /// </summary>
        static void WinCondition()
        {
            if (numUnknownSpaces == 0)
            {
                playing = "n";
                win = true;
            }
        }

        /// <summary>
        /// Writes the tutorial text
        /// </summary>
        static void WriteTutorial()
        {
            Console.WriteLine("How to play: Use the console to write which fields you want to select like a cordinate system");
            Console.WriteLine("Examples: 56, 84 and 37");
            Console.WriteLine("To place flags write f after the field you want to select");
            Console.WriteLine("Examples: 27f, 12f and 88f");
            Console.WriteLine("Write q to exit program");
            Console.WriteLine();
        }
    }
}

