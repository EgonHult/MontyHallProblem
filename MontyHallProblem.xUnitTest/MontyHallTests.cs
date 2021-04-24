using System;
using Xunit;
using MontyHallProblem;
namespace MontyHallProblem.xUnitTest
{
    public class MontyHallTests
    {
        [Theory]
        [InlineData(5, 10)]      
        [InlineData(10000, 20000)]
        public void CalculateWinningAccuracy_InsertTwoValidValues_ReturnTheQuotientMultipliedWithHundred(int dividend, int divisor)
        {
            var sut =  Helpers.CalculateWinningAccuracy(dividend, divisor);

            Assert.Equal(50, sut);
        }


        [Theory]
        [InlineData(5, 0)]
        [InlineData(0, -1)]
        [InlineData(10000, -1000)]
        public void CalculateWinningAccuracy_InsertInValidValue_ReturnExeption(int dividend, int divisor)
        {
            var ex = Assert.Throws<Exception>(() => Helpers.CalculateWinningAccuracy(dividend, divisor));         
        }


    }
}
