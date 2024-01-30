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

        // Contain a method that prints the board based on the information passed to it
        public void printBoard(int[,] guess)
        {
            string[,] board = new string[3, 3];

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
        public string CheckWinner(int guess) 
        { 
            
            
        }
    }
}
