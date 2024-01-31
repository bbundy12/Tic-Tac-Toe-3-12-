using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe__3_12_
{

    internal class GameBoard
    {
        string[,] board = new string[3, 3];

        // Contain a method that prints the board based on the information passed to it
        public void printBoard(int[,] guess)
        {
           
            // Initialize the board with empty slots
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = "_";
                }
            }

            for (int k = 0; k < guess.GetLength(0); k++ )
            {
                int row = 0;
                int col = 0;
                int position = guess[k, 0];

                // Setting the correct coordinates with letters based on the guess array
                if (position != 0)
                {
                    // Calculating the coordinates with the letters
                    if (position % 3 == 0)
                    {
                        row = (position / 3) - 1;
                        col = 0;
                    }
                    else if (position % 3 != 0)
                    {
                        col = (position % 3) - 1;
                        row = ((position - (position % 3)) / 3) - 1;
                    }

                    // Setting the right letter
                    if (guess[k, 1] % 2 == 0)
                    {
                        board[row, col] = "O";
                    }
                    else
                    {
                        board[row, col] = "X";
                    }

                    // Print the board
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(board[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }

              }
            
        }

        //  Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public string CheckWinner(string[,] gameBoard) 
        {
            string winner = "";
            bool gameOver = false;
            bool draw = true;

            // for loop
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "_")
                    winner = board[i, 0];
                    gameOver = true;

                // Check columns
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "_")
                    winner = board[0, i];
                    gameOver = true;
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "_")
                winner= board[0, 0];
                gameOver = true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != "_")
                winner= board[0, 2];
                gameOver = true;

            // Determinging if there is a draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != "_")
                    {
                        draw = false;
                        break;
                    }
                }

            }

            //Print message if there is a winner
            if (gameOver)
            {
                return $"Congratulations! {winner}'s win!! ";
            }
            else if (draw)
            {
                return "The match is a draw. Better luck next time!";
            }
            else
            {
                return "";
            }


        }



       /* // Board method which creats board
        public static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }*/

    }
}
