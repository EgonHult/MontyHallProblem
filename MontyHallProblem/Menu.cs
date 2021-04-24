using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem
{
    public class Menu
    {
        internal static int ChangeOrKeepDoor()
        {
            bool isRunning = true;
            int pickDoor = 0;
            while (isRunning)
            {
                Console.WriteLine("[1] Change door");
                Console.WriteLine("[2] Keep door");
                int.TryParse(Console.ReadLine(), out pickDoor);

                if (pickDoor == 1 || pickDoor == 2)
                    isRunning = false;
            }

            return pickDoor;
        }

        internal static int NumberOfSimulationsInput()
        {
            int noOfSimulations;
            do
            {
                int.TryParse(Console.ReadLine(), out noOfSimulations);
                if (ValidInput(noOfSimulations))
                    Console.WriteLine("\nEnter a number between 1 and 100´000´000");

            } while (ValidInput(noOfSimulations));
            return noOfSimulations;
        }

        private static bool ValidInput(int noOfSimulations)
        {
            return noOfSimulations <= 0 || noOfSimulations > 100_000_000;
        }
    }
}
