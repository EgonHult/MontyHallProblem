using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem
{
    public class Menu
    {

        internal static int NumberOfSimulations()
        {
            Console.WriteLine("\nHow many simulations do you whant to do? (Tips: Go high and simulat at least 10000 games for higher accuracy)\n");

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


        internal static bool ChangeOrKeepDoor()
        {

            bool isRunning = true;
            bool? KeepDoor = null;

            do
            {
                Console.WriteLine("\nChoose if you whant to change or keep the door\n");
                Console.WriteLine("[1] Change door");
                Console.WriteLine("[2] Keep door\n");
                int.TryParse(Console.ReadLine(), out int decision);

                if (decision == 1)
                {
                    KeepDoor = false;
                    isRunning = false;
                }
                else if (decision == 2)
                {
                    KeepDoor = true;
                    isRunning = false;
                }

            } while (isRunning);

            return (bool)KeepDoor;
        }

        internal static void EndMessage(int noOfSimulations, int winningGames, double winningpercentage)
        {
            Console.WriteLine("\nNew car owners:\t" + winningGames +
                              "\n\nAttempts:\t" + noOfSimulations);

            Console.WriteLine($"\nWinning accuracy: {winningpercentage}%");
            Console.WriteLine("\nPress any key to try again");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
