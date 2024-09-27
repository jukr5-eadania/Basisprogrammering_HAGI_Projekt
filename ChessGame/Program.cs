using System;


namespace Chess
{
    enum ChessPiece { o, P, R, N, B, K, Q, p, r, n, b, k, q }
    internal class ChessGame
    {
        static ChessPiece[,] board = new ChessPiece[8, 8];
        static void Main(string[] args)
        {
            board[0, 0] = ChessPiece.R;
            board[1, 0] = ChessPiece.N;
            board[2, 0] = ChessPiece.B;
            board[3, 0] = ChessPiece.Q;
            board[4, 0] = ChessPiece.K;
            board[5, 0] = ChessPiece.B;
            board[6, 0] = ChessPiece.N;
            board[7, 0] = ChessPiece.R;

            board[0, 1] = ChessPiece.P;
            board[1, 1] = ChessPiece.P;
            board[2, 1] = ChessPiece.P;
            board[3, 1] = ChessPiece.P;
            board[4, 1] = ChessPiece.P;
            board[5, 1] = ChessPiece.P;
            board[6, 1] = ChessPiece.P;
            board[7, 1] = ChessPiece.P;

            board[0, 6] = ChessPiece.p;
            board[1, 6] = ChessPiece.p;
            board[2, 6] = ChessPiece.p;
            board[3, 6] = ChessPiece.p;
            board[4, 6] = ChessPiece.p;
            board[5, 6] = ChessPiece.p;
            board[6, 6] = ChessPiece.p;
            board[7, 6] = ChessPiece.p;

            board[0, 7] = ChessPiece.r;
            board[1, 7] = ChessPiece.n;
            board[2, 7] = ChessPiece.b;
            board[3, 7] = ChessPiece.q;
            board[4, 7] = ChessPiece.k;
            board[5, 7] = ChessPiece.b;
            board[6, 7] = ChessPiece.n;
            board[7, 7] = ChessPiece.r;




            while (true)
            {
                DrawBoard();
                char[] currentMove = Console.ReadLine().ToCharArray();

                MovePiece((int)char.GetNumericValue(currentMove[0]), (int)char.GetNumericValue(currentMove[1]), (int)char.GetNumericValue(currentMove[2]), (int)char.GetNumericValue(currentMove[3]));
            }
        }
        static void DrawBoard()
        {
            Console.Clear();
            for (int y = 7; y > -1; y--)
            {
                Console.WriteLine("* - * - * - * - * - * - * - * - *");
                Console.Write(y);
                for (int x = 0; x < 8; x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    if ((board[x, y]) != (ChessPiece.o))
                    {
                        Console.Write($" {board[x, y]} ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("* 0 * 1 * 2 * 3 * 4 * 5 * 6 * 7 *");
        }

        static void MovePiece(int x1, int y1, int x2, int y2)
        {
            board[x2, y2] = board[x1, y1];
            board[x1, y1] = ChessPiece.o;
        }
    }
}
