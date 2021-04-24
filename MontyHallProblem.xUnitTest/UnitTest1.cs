using System;
using Xunit;
using MontyHallProblem;
namespace MontyHallProblem.xUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 10)]
        [InlineData(10, 20)]
        [InlineData(20, 40)]
        [InlineData(10000, 20000)]
        public void CalculateWinningAccuracy_InsertTwoValidValues_aaa(int a, int b)
        {
            var sut =  Helpers.CalculateWinningAccuracy(a, b);

            Assert.Equal(50, sut);
        }


        [Theory]
        [InlineData(5, 0)]
        [InlineData(0, 0)]
        [InlineData(20, 0)]
        [InlineData(10000, 0)]
        public void CalculateWinningAccuracy_InsertInValidValue_bbb(int a, int b)
        {
            var ex = Assert.Throws<Exception>(() => Helpers.CalculateWinningAccuracy(a, b));         
        }


    }
}
