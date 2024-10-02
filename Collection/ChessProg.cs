using System;


namespace Chess
{
    enum ChessPiece { o, P, R, N, B, K, Q, p, r, n, b, k, q }
    internal class ChessGame
    {
        static int xPos = 0;
        static int yPos = 0;
        static int xPosSel = 8;
        static int yPosSel = 8;
        static bool pieceSelected = false;
        static bool playingChess = true;
        static ChessPiece[,] board = new ChessPiece[8, 8];
        public static void PlayChess()
        {
            ResetBoard();

            while (playingChess)
            {
                DrawBoard();

                // Moves cursor depending on input
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (yPos < 7)
                            {
                                yPos++;
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (yPos > 0)
                            {
                                yPos--;
                            }
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (xPos > 0)
                            {
                                xPos--;
                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (xPos < 7)
                            {
                                xPos++;
                            }
                            break;
                        }
                    // Selects / moves piece
                    case ConsoleKey.Enter :
                        {
                            MovePiece();
                            break;
                        }
                    // Exits gameloop
                    case ConsoleKey.Escape:
                        {
                            playingChess = false;
                            break;
                        }
                }
            }
            // exit to menu goes here
        }
        /// <summary>
        /// Resets the board to the starting position
        /// </summary>
        static void ResetBoard()
        {
            playingChess = true;

            // Empties board
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    board[x, y] = ChessPiece.o;
                }
            }
            // Places pieces
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
        }
        /// <summary>
        /// Draws the board
        /// </summary>
        static void DrawBoard()
        {
            Console.Clear();
            
            for (int y = 7; y > -1; y--)
            {
                Console.WriteLine("* - * - * - * - * - * - * - * - *");
                Console.Write(y + 1);
                for (int x = 0; x < 8; x++)
                {
                    // Highlights the cursor and selected piece
                    if (x == xPos && y == yPos)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (x == xPosSel && y == yPosSel)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    // Draws alternating white and green squares
                    else
                    {
                        // If number is even
                        if ((x + y) % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        // If number is odd
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    // Draws pieces. If square is empty, draws a blank square 
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
            Console.WriteLine("* A * B * C * D * E * F * G * H *");
        }

        static void MovePiece()
        {
            // If no piece is selected, selects a piece
            if (pieceSelected == false && board[xPos, yPos] != ChessPiece.o)
            {
                xPosSel = xPos;
                yPosSel = yPos;
                pieceSelected = true;
            }
            // When selecting a selected piece, unselects it
            else if (pieceSelected == true && xPos == xPosSel && yPos == yPosSel)
            {
                xPosSel = 8;
                yPosSel = 8;
                pieceSelected = false;
            }
            // Moves selected piece to new position
            else if (pieceSelected == true)
            {
                board[xPos, yPos] = board[xPosSel, yPosSel];
                board[xPosSel, yPosSel] = ChessPiece.o;
                xPosSel = 8;
                yPosSel = 8;
                pieceSelected = false;
            }
        }
    }
}
