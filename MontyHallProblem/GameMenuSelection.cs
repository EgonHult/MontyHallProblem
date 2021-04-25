using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem
{
    public class GameMenuSelection
    {
        internal static int ChangeOrKeepDoor()
        {
            bool isRunning = true;
            int changeOrKeep = 0;

            while (isRunning)
            {
                Console.WriteLine("Choose if you whant to change or keep the door\n");
                Console.WriteLine("[1] Change door");
                Console.WriteLine("[2] Keep door\n");
                int.TryParse(Console.ReadLine(), out changeOrKeep);

                if (changeOrKeep == 1 || changeOrKeep == 2)
                    isRunning = false;
            }

            return changeOrKeep;
        }

        internal static int NumberOfSimulations()
        {
            int noOfSimulations;

            do
            {
                int.TryParse(Console.ReadLine(), out noOfSimulations);
                if (ValidateInput(noOfSimulations))
                    Console.WriteLine("\nEnter a number between 1 and 10´000´000\n");

            } while (ValidateInput(noOfSimulations));

            return noOfSimulations;
        }

        private static bool ValidateInput(int noOfSimulations)
             => noOfSimulations <= 0 || noOfSimulations > 10_000_000;
        
    }
}
