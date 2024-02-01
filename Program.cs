
//Declare instance of class
using System.Linq;
using Tic_Tac_Toe__3_12_;

GameBoard gb = new GameBoard();


//• Create a game board array to store the players’ choices
int[,] guess = new int[9, 2] ;
int[] numbersGuessed = new int[0];
string input = "";
int position = 0;

bool gameOver = false;

//testing 

//Welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine("\nUse the following grid to know what numbers correlate with which position\n");
Console.WriteLine("\t\t1 2 3\n\t\t4 5 6\n\t\t7 8 9\n");

//Method to create board at the beginning
//GameBoard.Board();

//• Ask each player in turn for their choice and update the game board array

    for (int i = 1; i < 10 && !gameOver; i++) //Loop for guesses to auto-increment move number
    {
        string letter = "";

        if (i % 2 == 0)
        {
            letter = "O";
        }
        else
        {
            letter = "X";
        }

        Console.WriteLine($"\nIt is {letter}'s turn. Where do you want to place your piece?");

        bool validInput = false;

        while (!validInput)// Get a valid input
        {
            input = Console.ReadLine();
            Console.WriteLine();

            // Check if input is a single character and represents a digit
            if (input.Length == 1 && char.IsDigit(input[0]))
            {
                position = int.Parse(input);


                // Check if the parsed number is within the range and exists in numbersGuessed array
                if (!numbersGuessed.Contains(position) && position > 0)
                {
                    validInput = true;
                    //Add the number guessed into the array
                    Array.Resize(ref numbersGuessed, numbersGuessed.Length + 1);
                    numbersGuessed[numbersGuessed.Length - 1] = position;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number 1-9 that has not been guessed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number 1-9 that has not been guessed.");
            }
        }

        //Put position number into first section of guess variable
        guess[i - 1, 0] = position;

        //Put i into the second section of the guess variable
        guess[i - 1, 1] = i;

        //• Print the board by calling the method in the supporting class
        string[,] board = gb.printBoard(guess);

        ////• Check for a winner by calling the method in the supporting class, and notify the players 
        if (i >= 5)
        {
            gameOver = gb.CheckWinner(board);
        }
        

    }
Console.WriteLine("Press Enter to exit the game.");
Console.ReadLine();
