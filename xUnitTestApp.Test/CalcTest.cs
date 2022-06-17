using ClassLibraryApp;

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

    }
}
