using System;
using Xunit;
using static MontyHallProblem.Helpers;

namespace MontyHallProblem.xUnitTest
{
    public class HelpersTests
    {

        [Theory]       
        [InlineData(455, 2478, 18.36)]       
        [InlineData(7, 10, 70)]
        [InlineData(int.MinValue, 5, -42949672960)]
        [InlineData(int.MinValue, int.MaxValue, -100)]
        [InlineData(int.MaxValue, 2, 107374182350)]
        public void CalculateNumberOfWinsToPercent_SetTwoValidValues_ReturnTheQuotientMultipliedWithHundred(int dividend, int divisor, double expected)
        {
            double actual = CalculateNumberOfWinsToPercent(dividend, divisor);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(5, 0)]
        [InlineData(10000, -1450)]
        [InlineData(1, int.MinValue)]              
        public void CalculateNumberOfWinsToPercent_SetInvalidValues_ReturnExeption(int dividend, int divisor)
        {
            var ex = Assert.Throws<Exception>(() => CalculateNumberOfWinsToPercent(dividend, divisor));
            Assert.Equal("You can't divide something with zero and we won't let you set the dividor to a negative number", ex.Message);
        }
    }
}
