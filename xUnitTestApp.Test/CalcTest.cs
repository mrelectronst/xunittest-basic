﻿using ClassLibraryApp;

namespace xUnitTestApp.Test
{

    public class CalcTest
    {
        [Fact]
        public void SumTest()
        {
            //Arrange
            int a = 1;
            int b = 2;
            var calc = new Calc();

            //Act
            var result = calc.sum(a, b);

            //Assert
            Assert.Equal<int>(3, result);
        }

        [Fact]
        public void SumInRangeTest()
        {
            //Arrange
            int a = 5;
            int b = 27;
            var calc = new Calc();

            //Act
            var result = calc.sum(a, b);

            //Assert
            Assert.InRange(result, 30, 45);
            //Assert.NotInRange(result, 30, 45);
        }

        [Fact]
        public void FindOddNumbersTest()
        {
            //Arrange
            int start = 1;
            int end = 10;
            var calc = new Calc();

            //Act
            var result = calc.FindOddNumbers(start, end);

            //Assert
            Assert.Contains(3, result);
        }

        [Fact]
        public void FindOddNumbersEmptyTest()
        {
            //Arrange
            int start = 2;
            int end = 5;
            var calc = new Calc();

            //Act
            var result = calc.FindOddNumbers(start, end);

            //Assert
            //Assert.Empty(result);
            Assert.NotEmpty(result);
        }


        [Fact]
        public void IsGreaterThanTest()
        {
            //Arrange
            int a = 5;
            int b = 2;
            var calc = new Calc();

            //Act
            var result = calc.IsGreaterThan(a, b);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLessThanTest()
        {
            //Arrange
            int a = 1;
            int b = 2;
            var calc = new Calc();

            //Act
            var result = calc.IsLessThan(a, b);

            //Assert
            Assert.True(result);
        }

    }
}
