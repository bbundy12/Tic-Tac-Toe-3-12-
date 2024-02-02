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
        public string[,] printBoard(int[,] guess) 
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

            //Setting the correct coordinates with letters based on the guess array
            for (int k = 0; k < guess.GetLength(0); k++ )
            {
                int row = 0;
                int col = 0;
                int position = guess[k, 0];
                
                if (position != 0)
                {
                    // Set the correct coordinates for the letter to go based on the guess
                    row = (position - 1) / 3;
                    col = (position - 1) % 3;

                    // Setting the right letter
                    if (guess[k, 1] % 2 == 0)
                    {
                        board[row, col] = "O";
                    }
                    else
                    {
                        board[row, col] = "X";
                    }
                    
                }
              
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

            return board;
          
            
        }

        //  Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public bool CheckWinner(string[,] board) 
        {
            string winner = "";
            bool gameOver = false;
            bool draw = true;

            for (int i = 0; i < 3 && !gameOver; i++)
            {
                // Check rows
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "_")
                {
                    winner = board[i, 0];
                    gameOver = true;
                }                    

                // Check columns
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "_")
                {
                    winner = board[0, i];
                    gameOver = true;
                }
                    
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "_")
            {
                winner = board[0, 0];
                gameOver = true;
            }
               
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != "_")
            {
                winner = board[0, 2];
                gameOver = true;
            }
                

            // Determinging if there is a draw
            for (int i = 0; i < 3 && !gameOver; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "_")
                    {
                        draw = false;
                        break;
                    }
                }
            }

            //Print message
            if (gameOver)
            {
                Console.WriteLine($"\nCongratulations! {winner} wins!");
                return true;
            }
            else if (draw)
            {
                Console.WriteLine("\nThe match is a draw. Better luck next time!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
