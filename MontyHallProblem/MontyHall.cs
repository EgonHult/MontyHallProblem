﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MontyHallProblem
{
    public class MontyHall
    {
        readonly Random _random = new Random();

        private int PrizeDoor { get; set; }
        private int ChosenDoor { get; set; }
        private int OpenDoor { get; set; }


        /// <summary>
        /// Play the Monty Hall Game
        /// </summary>
        /// <param name="noOfSimulations"></param>
        /// <param name="changeOrKeep"> Change door = 1. Keep door = 2</param>
        /// <returns> Number of winning Games</returns>
        public static int MontyHallGame(int noOfSimulations, int changeOrKeep)
        {

            if (ValidatParameters(noOfSimulations, changeOrKeep))
                throw new Exception("One or both parameters are invalid");

            int winningGames = 0;

                MontyHall montyHall = new MontyHall();

                for (int i = 0; i < noOfSimulations; i++)
                {

                    montyHall.SetPrizeDoorRandomly();
                    montyHall.ChooseDoorRandomly();
                    montyHall.OpenOneDoor();

                    if (changeOrKeep == 1)
                    {
                        if (montyHall.ChangeDoor())
                        {
                            winningGames++;
                        }
                    }

                    if (changeOrKeep == 2)
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
        {
            PrizeDoor = _random.Next(0, 3);
        }

        private void ChooseDoorRandomly()
        {
            ChosenDoor = _random.Next(0, 3);
        }
        private void OpenOneDoor()
        {
            do
            {
                OpenDoor = _random.Next(0, 3);
            } while (OpenDoor == PrizeDoor || OpenDoor == ChosenDoor);
        }


        private static bool ValidatParameters(int noOfSimulations, int changeOrKeep)
          => noOfSimulations < 1  || noOfSimulations > 10_000_000 || !Regex.IsMatch(changeOrKeep.ToString(), "^[1-2]{1}$");
    }
}
