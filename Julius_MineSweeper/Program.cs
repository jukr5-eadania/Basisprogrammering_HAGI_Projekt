using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        static void Main(string[] args)
        {
            WriteNewMSB();

            Console.ReadLine();
        }

        static void WritePlayerMSB()
        {
            sideGridNumber = 0;
            Console.WriteLine("    a   b   c   d   e   f   h   i");

            for (int x = 0; x < newMSB.GetLength(0); x++)
            {
                Console.WriteLine("  * - * - * - * - * - * - * - * - *");
                Console.Write(sideGrid[sideGridNumber] + " | ");
                sideGridNumber++;
                for (int y = 0; y < newMSB.GetLength(1); y++)
                {
                    Console.Write(newMSB[x, y] + " ");
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
            for (int x = 1; x < newMSB.GetLength(0) - 1; x++)
            {
                for (int y = 1; y < newMSB.GetLength(1) - 1; y++)
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
                        newMSB[x, y] = (int) ((Spaces)bombs);
                    }

                }

            }

            //Writes the new MS board (Mainly used for testing if if the function works)
            //sideGridNumber = 0;
            //Console.WriteLine("    a   b   c   d   e   f   h   i");
            //for (int x = 1; x < newMSB.GetLength(0) - 1; x++)
            //{
            //    Console.WriteLine("  * - * - * - * - * - * - * - * - *");
            //    Console.Write(sideGrid[sideGridNumber] + " | ");
            //    sideGridNumber++;
            //    for (int y = 1; y < newMSB.GetLength(1) - 1; y++)
            //    {
            //        Console.Write(newMSB[x, y] + " ");
            //        Console.Write("| ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine("  * - * - * - * - * - * - * - * - *");
        }
    }

}
