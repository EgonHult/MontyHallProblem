using System;
using Xunit;
using MontyHallProblem;
namespace MontyHallProblem.xUnitTest
{
    public class MontyHallTests
    {
        [Theory]
        [InlineData(5, 10, 50)]      
        [InlineData(455, 2478, 18)]      
        [InlineData(10 , 4, 250)]
        [InlineData(7 , 10, 70)]
        [InlineData(int.MinValue, 5, -42949672960)]
        [InlineData(int.MinValue, int.MaxValue, -100)]

        public void CalculateWinningAccuracy_InsertTwoValidValues_ReturnTheQuotientMultipliedWithHundred(int dividend, int divisor, double expected)
        {
            double actual =  Helpers.CalculateWinningAccuracy(dividend, divisor);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(5, 0)]
        [InlineData(10000, -1000)]
        [InlineData(1, int.MinValue)]
        public void CalculateWinningAccuracy_InsertInValidValue_ReturnExeption(int dividend, int divisor)
        {
            Assert.Throws<Exception>(() => Helpers.CalculateWinningAccuracy(dividend, divisor));         
        }


    }
}
