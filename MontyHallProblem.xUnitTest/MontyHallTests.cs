using System;
using Xunit;
using static MontyHallProblem.Game;


namespace MontyHallProblem.xUnitTest
{
    public class MontyHallTests
    {

        [Theory]
        [InlineData(5, 2)]
        [InlineData(10_000_000, 1)]
        [InlineData(165_464, 2)]
        [InlineData(5, 1)]
        [InlineData(1, 2)]
        public void MontyHallGame_SetTwoValidParameters_ReturnInt32(int noOfSimulations, int changeOrKeep)
        {

            var actual = MontyHallGame(noOfSimulations, changeOrKeep);

            Assert.Equal(typeof(int), actual.GetType());
        }


        [Theory]
        [InlineData(5, 12)]      
        [InlineData(0, 1)]
        [InlineData(0, 2)]
        [InlineData(-5, 45)]
        [InlineData(int.MinValue, int.MaxValue)]      
        [InlineData(2, int.MinValue)]
        [InlineData(int.MaxValue, 1)]
        [InlineData(10_000_001, 2)]
        public void MontyHallGame_SetInvalidParameters_ReturnExeption(int noOfSimulations, int changeOrKeep)
        {

            var ex = Assert.Throws<Exception>(() => MontyHallGame(noOfSimulations, changeOrKeep));
            Assert.Equal("One or both parameters are invalid", ex.Message);
        }
    }
}
