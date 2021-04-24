using System;

namespace MontyHallProblem
{
    class Program : Helpers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and welcome to The Monty Hall game");
            Console.WriteLine("How many simulations do you whant to do? (tips go high and simulat at least 10000 games for more accuracy)");

            int noOfSimulations;
            do
            {
                int.TryParse(Console.ReadLine(), out noOfSimulations);
                if (noOfSimulations == 0)
                    Console.WriteLine("Enter a number between 1 and 100´000´000");

            } while (noOfSimulations == 0);

            Console.WriteLine();

            int rightDecision = 0;


            MontyHall montyHall = new MontyHall();


            for (int i = 0; i < noOfSimulations; i++)
            {

                montyHall.SetPrizeDoor();
                montyHall.SelectDoor();
                montyHall.RevealDoor();

                if (montyHall.SholdSwitch())
                {
                    rightDecision++;
                }
            }

            Console.WriteLine(rightDecision + "   " + noOfSimulations);

            decimal accuracyInProcent = CalculateWinningAccuracy(rightDecision, noOfSimulations);

            Console.WriteLine($"Winning accuracy in procent: {accuracyInProcent}%");

        }
    }

    public class MontyHall
    {
        readonly Random _random = new Random();

        public int PrizeDoor { get; set; }
        public int ChosenDoor { get; set; }
        public int OpenDoor { get; set; }

        public bool SholdSwitch()
        {
            return PrizeDoor != ChosenDoor;
        }

        public void RevealDoor()
        {
            do
            {
                OpenDoor = _random.Next(0, 3);
            } while (OpenDoor == ChosenDoor || OpenDoor == PrizeDoor);
        }

        public void SetPrizeDoor()
        {
            PrizeDoor = _random.Next(0, 3);
        }

        public void SelectDoor()
        {
            ChosenDoor = _random.Next(0, 3);
        }
    }

}
