using System;

namespace MontyHallProblem
{
    public class Helpers
    {

        /// <summary>
        ///  Calculates the percentage between two numbers
        /// </summary>
        /// <param name="winningGames"></param>
        /// <param name="noOfSimulations"></param>
        /// <returns>Wins in percent rounded to integer</returns>
        
        public static double CalculateNumberOfWinsToPercent(int winningGames, int noOfSimulations)
        {
            if (noOfSimulations <= 0)
                throw new Exception("You can't divide something with zero and we won't let you set the dividor to a negative number");

            double winningpercentage = (winningGames / (double)noOfSimulations) * 100;

            return Math.Round(winningpercentage, 2);
        }
    }
}