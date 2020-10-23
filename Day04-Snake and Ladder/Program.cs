/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day04EmployeeWageCompuatation.exe Day03EmployeeWageCompuatation.cs
 *  Execution:    Day04SNAKE AND LADDER.exe 103
 *  
 *  Purpose: Player rolls the die
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
        public const int END_POINT = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            //user input
            string player1 = Console.ReadLine();
            //initialization
            int diceRoll = DiceRoll();
            Console.WriteLine("Dice Roll : " + diceRoll);
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
    }
}
