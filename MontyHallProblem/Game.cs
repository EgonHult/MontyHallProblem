using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MontyHallProblem
{
    public class Game
    {
        readonly Random _random = new Random();

        private int PrizeDoor { get; set; }
        private int ChosenDoor { get; set; }      

        /// <summary>
        /// Play the Monty Hall Game
        /// </summary>
        /// <param name="noOfSimulations"></param>
        /// <param name="KeepDoor"></param>
        /// <returns> Number of winning Games</returns>
        public static int MontyHallGame(int noOfSimulations, bool? KeepDoor)
        {

            if (ValidatParameter(noOfSimulations, KeepDoor))
                throw new Exception("One or both parameters are invalid");

            int winningGames = 0;

                Game montyHall = new Game();

                for (int i = 0; i < noOfSimulations; i++)
                {

                    montyHall.SetPrizeDoorRandomly();
                    montyHall.ChooseDoorRandomly();                  

                    if (KeepDoor is false)
                    {
                        if (montyHall.ChangeDoor())
                        {
                            winningGames++;
                        }
                    }

                    else if (KeepDoor is true)
                    {
                        if (montyHall.KeepDoor())
                        {
                            winningGames++;
                        }
                    }
                }

                return winningGames;
        }


        private bool ChangeDoor()
            => PrizeDoor != ChosenDoor;
        
        private bool KeepDoor()       
            => PrizeDoor == ChosenDoor;

        private void SetPrizeDoorRandomly()       
            => PrizeDoor = _random.Next(0, 3);
        
        private void ChooseDoorRandomly()
            => ChosenDoor = _random.Next(0, 3);


        private static bool ValidatParameter(int noOfSimulations, bool? KeepDoor)
            => noOfSimulations < 1 || noOfSimulations > 10_000_000 || KeepDoor == null;
    }
}
