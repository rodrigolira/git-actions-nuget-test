using System;
using Xunit;

namespace GitActionsNugetTest.MyLibrary.Tests
{
    public class SuperCalculatorTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        public void CanSumTwoIntegers(int x, int y)
        {
            var calculator = new SuperCalculator();

            int sumResult = calculator.Sum(x, y);

            Assert.Equal(sumResult, x + y);
        }
    }
}
