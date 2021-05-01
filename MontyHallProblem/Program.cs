﻿using System;
using static MontyHallProblem.Menu;

namespace MontyHallProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nHello, and welcome to The Monty Hall Game!!!");

            while (true)
            {
                int noOfSimulations = NumberOfSimulations();
                Console.Clear();

                bool KeepDoor = ChangeOrKeepDoor();
                Console.Clear();

                Console.WriteLine("\nPerfect! Press any key to se the result");
                Console.ReadKey();
                Console.Clear();

                int winningGames = Game.MontyHallGame(noOfSimulations, KeepDoor);

                double winningpercentage = Helpers.CalculateNumberOfWinsToPercent(winningGames, noOfSimulations);

                EndMessage(noOfSimulations, winningGames, winningpercentage);
            }
        }      
    }
}
