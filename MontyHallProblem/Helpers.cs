using System;

namespace MontyHallProblem
{
    public class Helpers
    {

        public static double CalculateWinningAccuracy(int rightDecision, int noOfSimulations)
        {
            if (noOfSimulations <= 0)
                throw new Exception("You can't divide something with zero or lover");

            double accuracyInProcent = (rightDecision / (double)noOfSimulations) * 100;

            return Math.Round(accuracyInProcent);
        }
    }
}