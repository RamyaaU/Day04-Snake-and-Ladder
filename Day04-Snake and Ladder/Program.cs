/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day04EmployeeWageCompuatation.exe Day03EmployeeWageCompuatation.cs
 *  Execution:    Day04SNAKE AND LADDER.exe 103
 *  
 *  Purpose: Game played with single player
 *
 *  @author  Ramya U
 *  @version 1.0
 *  @since   22-10-2020
 *
 ******************************************************************************/

using System;

namespace SnakeAndLadder
{
    class Program
    {
        //constants
        public const int START_POINT = 0;
        public const int FINISH_POINT = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            string player1 = Console.ReadLine(); //userinput
            int playerPosition = START_POINT;
            Console.WriteLine("Current Position : " + playerPosition);
        }
    }
}