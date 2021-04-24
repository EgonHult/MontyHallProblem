using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem
{
    public class MontyHall
    {
        readonly Random _random = new Random();

        private int PrizeDoor { get; set; }
        private int ChosenDoor { get; set; }
        private int OpenDoor { get; set; }

        public static int MontyHallGame(int noOfSimulations, int selectedDoor)
        {
            int rightDecision = 0;

            MontyHall montyHall = new MontyHall();

            for (int i = 0; i < noOfSimulations; i++)
            {

                montyHall.SetPrizeDoorRandomly();
                montyHall.ChooseDoorRandomly();
                montyHall.RevealDoor();

                if (selectedDoor == 1)
                {

                    if (montyHall.SwithDoor())
                    {
                        rightDecision++;
                    }
                }

                if (selectedDoor == 2)
                {
                    if (montyHall.KeepDoor())
                    {
                        rightDecision++;
                    }
                }
            }

            return rightDecision;
        }



        private bool SwithDoor()
        {
            return PrizeDoor != ChosenDoor;
        }

        private bool KeepDoor()
        {
            return PrizeDoor == ChosenDoor;
        }

        private void RevealDoor()
        {
            do
            {
                OpenDoor = _random.Next(0, 3);
            } while (OpenDoor == PrizeDoor || OpenDoor == ChosenDoor);
        }

        private void SetPrizeDoorRandomly()
        {
            PrizeDoor = _random.Next(0, 3);
        }

        private void ChooseDoorRandomly()
        {
            ChosenDoor = _random.Next(0, 3);
        }
    }
}
