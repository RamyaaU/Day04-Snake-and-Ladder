/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Snake and ladder
 *  Execution:    Day04SNAKE AND LADDER.exe 103
 *  
 *  Purpose: Player repeats
 *
 *  @author  Ramya U
 *  @version 1.0
 *  @since   22-10-2020
 *
 ******************************************************************************/
using System;

namespace Day04_Snake_and_Ladder
{
    class Program
    {
        //constants
        public const int START_POINT = 0;
        public const int FINISH_POINT = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            string player1 = Console.ReadLine(); //userinput
            int playerCurrentPosition = START_POINT; //initialization
            //for loop is used to check no of times dice rolled and current position of player
            //and also executes repeatedly until the condition fails
            for (int noOfTimesDiceRolled = 1; playerCurrentPosition >= 0; noOfTimesDiceRolled++)
            {
                int diceRoll = DiceRoll();
                Console.WriteLine("You rolled: " + diceRoll);
                playerCurrentPosition = PlayerMovement(diceRoll, playerCurrentPosition);
                Console.WriteLine("Your position: " + playerCurrentPosition);
                if (playerCurrentPosition >= 100)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                Console.ReadLine();
            }
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7); //returns a number between 1 and 7
            return diceNumber;
        }

        static int PlayerMovement(int numberRolled, int playerPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            //using switch case to check the conditions
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:
                    Console.WriteLine("Snake");
                    if (playerPosition - numberRolled >= 0)
                    {
                        playerPosition = playerPosition - numberRolled;
                        break;
                    }
                    else
                    {
                        playerPosition = START_POINT;
                        break;
                    }
                case LADDER:
                    Console.WriteLine("Ladder");
                    playerPosition = playerPosition + numberRolled;
                    break;
            }
            return playerPosition;
        }
    }
}

