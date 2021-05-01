using System;
using Xunit;
using static MontyHallProblem.Game;


namespace MontyHallProblem.xUnitTest
{
    public class GameTests
    {

        [Theory]
        [InlineData(1, true)]
        [InlineData(5, true)]
        [InlineData(165_464, true)]
        [InlineData(5, false)]
        [InlineData(10_000_000, false)]
        public void MontyHallGame_SetTwoValidParameters_ReturnInt32(int noOfSimulations, bool? KeepDoor)
        {

            var actual = MontyHallGame(noOfSimulations, KeepDoor);

            Assert.Equal(typeof(int), actual.GetType());
        }


        [Theory]
        [InlineData(5, null)]      
        [InlineData(0, false)]
        [InlineData(0, true)]
        [InlineData(-5, null)]
        [InlineData(int.MinValue, null)]      
        [InlineData(2, null)]
        [InlineData(int.MaxValue, false)]
        [InlineData(10_000_001, true)]
        public void MontyHallGame_SetInvalidParameters_ReturnExeption(int noOfSimulations, bool? KeepDoor)
        {

            var ex = Assert.Throws<Exception>(() => MontyHallGame(noOfSimulations, KeepDoor));
            Assert.Equal("One or both parameters are invalid", ex.Message);
        }
    }
}
