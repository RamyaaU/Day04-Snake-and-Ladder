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
       
        static void Main(string[] args)
        {
            //constants
            const int noPlayOption = 0;
            const int ladderOption = 1;
            const int snakeOption = 2;
            const int playerOne = 1;
            //variable
            int positionOne = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("Die Rolls: " + dieRoll);
            int options = random.Next(0, 3);
            //switch case is used to check the condition
            switch (options)
            {
                case noPlayOption:
                    positionOne = positionOne + 0;
                    break;
                case ladderOption:
                    positionOne = positionOne + dieRoll;
                    break;
                case snakeOption:
                    positionOne = positionOne - dieRoll;
                    if (positionOne < 0)
                    {
                        positionOne = 0;
                    }
                    break;
            }
        }
    }
}

