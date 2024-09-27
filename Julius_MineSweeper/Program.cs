using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julius_MineSweeper
{
    enum Spaces
    {
        EmptySpace,
        One,
        Two,
        Three,
        Four,
        Five,
        Bomb

    }

    internal class Program
    {
        static Random rnd = new Random();
        static int[,] newMSB = new int[8, 8];
        static int[,] playerMSB = new int[8, 8];
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


        static void WriteNewMSB()
        {
            sideGridNumber = 0;
            Console.WriteLine("    a   b   c   d   e   f   h   i");
            
            for (int a = 0; a < 11; a++)
            {
                int rndX = rnd.Next(0, 8);
                int rndY = rnd.Next(0, 8);
                newMSB[rndX, rndY] = (int) Spaces.Bomb;
            }

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
    }

}
