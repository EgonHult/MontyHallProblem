using System;

namespace MontyHallProblem
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\nHello, and welcome to The Monty Hall Game!!!");

            while (true)
            {
                Console.WriteLine("\nHow many simulations do you whant to do? (Tips: Go high and simulat at least 10000 games for higher accuracy)\n");

                int noOfSimulations = GameMenuSelection.NumberOfSimulations();
                Console.Clear();
                Console.WriteLine();
                int selectedDoor = GameMenuSelection.ChangeOrKeepDoor();

                Console.Clear();
                Console.WriteLine("\nPerfect! Press any key to se the result");
                Console.ReadKey();
                Console.Clear();

                int winningGames = MontyHall.MontyHallGame(noOfSimulations, selectedDoor);
            
                double winningpercentage = Helpers.CalculateNumberOfWinsToPercent(winningGames, noOfSimulations);

                Console.WriteLine("\nNew car owners:\t" + winningGames +
                                  "\n\nAttempts:\t"+ noOfSimulations);

                Console.WriteLine($"\nWinning accuracy: {winningpercentage}%");
                Console.WriteLine("\nPress any key to try again");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
