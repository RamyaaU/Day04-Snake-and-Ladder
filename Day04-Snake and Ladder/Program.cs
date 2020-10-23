/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day04 SNAKE AND LADDER
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
        static void Main(string[] args)
        {
            const int playerOne = 1; //constants
            int positionOne = 0;
            Random random = new Random(); 
            int dieRoll = random.Next(1, 7);  //returns a random no betwenn 1 and 7
            Console.WriteLine("Die Rolls: " + dieRoll);
        }
    }
}
