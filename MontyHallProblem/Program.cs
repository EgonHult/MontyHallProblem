using System;

namespace MontyHallProblem
{
    class Program
    {

        static void Main(string[] args)
        {

                Console.WriteLine("\nHello and welcome to The Monty Hall game");
            while (true)
            {
                Console.WriteLine("How many simulations do you whant to do? (tips go high and simulat at least 10000 games for more accuracy)\n");


                int noOfSimulations = Menu.NumberOfSimulationsInput();
                int selectedDoor = Menu.ChangeOrKeepDoor();

                Console.Clear();
                Console.WriteLine("Perfect! Press any key to se the result");
                Console.ReadKey();
                Console.Clear();

                int rightDecision = MontyHall.MontyHallGame(noOfSimulations, selectedDoor);

                decimal accuracyInProcent = Helpers.CalculateWinningAccuracy(rightDecision, noOfSimulations);

                Console.WriteLine("\nVictories:\t" + rightDecision +
                    "\n\nAttempts:\t"+ noOfSimulations);

                Console.WriteLine($"\nWinning accuracy: {accuracyInProcent}%");
                Console.WriteLine("\nPress any key to try again");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
