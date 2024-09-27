using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julius_MineSweeper
{

    internal class Program
    {

        static int[,] mineSweeperBoard = new int[8, 8];
        static int[] sideGrid = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        static void Main(string[] args)
        {
            WriteMineSweeperBoard();

            Console.ReadLine();
        }
        static void WriteMineSweeperBoard()
        {
            int sideGridNumber = 0;
            
            Console.WriteLine("    a   b   c   d   e   f   h   i");
            for (int x = 0; x < mineSweeperBoard.GetLength(0); x++)
            {
                Console.WriteLine("  * - * - * - * - * - * - * - * - *");
                Console.Write(sideGrid[sideGridNumber] + " | ");
                sideGridNumber++;
                for (int y = 0; y < mineSweeperBoard.GetLength(1); y++)
                {
                    Console.Write(mineSweeperBoard[x, y] + " ");
                    Console.Write("| ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("  * - * - * - * - * - * - * - * - *");
        }
    }

}
