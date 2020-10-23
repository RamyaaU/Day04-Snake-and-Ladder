/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day04Snake and Ladder
 *  Execution:    Day04SNAKE AND LADDER.exe 103
 *  
 *  Purpose: Player checks option
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
        public const int FINISH_POINT = 10;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            string player1 = Console.ReadLine();    //userinput
            int playerPosition = START_POINT;  //initialization
            int diceRoll = DiceRoll();
            Console.WriteLine("Dice Roll : " + diceRoll);
            playerPosition = PlayerMovement(diceRoll, playerPosition); 
            Console.WriteLine("Your Position: " + playerPosition);
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7); //returns a number between 1 to 7
            return diceNumber;
        }
        static int PlayerMovement(int numberRolled, int playerPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move) //using switch case to check the conditions
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:
                    Console.WriteLine("Snake");
                    playerPosition = playerPosition - numberRolled;
                    break;
                case LADDER:
                    Console.WriteLine("Ladder");
                    playerPosition = playerPosition + numberRolled;
                    break;
            }
            return playerPosition;
        }
    }
}

