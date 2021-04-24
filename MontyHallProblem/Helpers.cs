using System;

namespace MontyHallProblem
{
    public class Helpers
    {

        public static decimal CalculateWinningAccuracy(int rightDecision, int noOfSimulations)
        {
            if (noOfSimulations == 0)
                throw new Exception("You can't divide something with zero");


            decimal accuracyInProcent = (rightDecision / (decimal)noOfSimulations) * 100;

            return Math.Round(accuracyInProcent);
        }
    }
}