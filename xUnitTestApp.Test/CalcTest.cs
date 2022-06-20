using ClassLibraryApp;
using Moq;

namespace xUnitTestApp.Test
{

    public class CalcTest
    {
        private readonly Calc _calc;
        private Mock<ICalcService> _calcMock;

        public CalcTest()
        {
            _calcMock = new Mock<ICalcService>();
            _calc = new Calc(_calcMock.Object);
        }

        [Fact]
        public void Sum_SimpleValues_ReturnTotalValue()
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            var result = _calc.sum(a, b);

            //Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(7, 3, 10)]
        [InlineData(4, 15, 19)]
        public void SumTestWithParameters(int a, int b, int expectedTotal)
        {
            //Arrange
            _calcMock.Setup(x => x.Sum(a, b)).Returns(expectedTotal);

            //Act
            var result = _calc.sum(a, b);

            //Assert
            Assert.Equal(expectedTotal, result);
        }

        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(7, 3, 21)]
        [InlineData(4, 15, 60)]
        public void Multiply_SimpleValues_ReturnResultOfMultiply(int a, int b, int expectedTotal)
        {
            //Arrange
            int actualResult = 0;
            //_calcMock.Setup(x => x.Multiply(a, b)).Returns(expectedTotal);
            _calcMock.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>((x, y) => actualResult = x * y)
            .Returns(expectedTotal);

            //Act
            _calc.multiply(a, b);

            //Assert
            Assert.Equal(expectedTotal, actualResult);
            //_calcMock.Verify(x => x.Multiply(a, b), Times.AtLeast(1));
        }

        [Theory]
        [InlineData(0, 3)]
        public void Multiply_ZeroValue_ReturnException(int a, int b)
        {
            //Arrange
            _calcMock.Setup(x => x.Multiply(a, b)).Throws(new Exception("Error"));

            //Act

            //Assert
            var ex = Assert.Throws<Exception>(() => _calc.multiply(a, b));

            Assert.Equal("Error", ex.Message);
        }

        [Fact]
        public void Sum_IsAssignableFromInt_ReturnTrue()
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            var result = _calc.sum(a, b);

            //Assert
            Assert.IsAssignableFrom<int>(result);
        }

        [Fact]
        public void SumInRangeTest()
        {
            //Arrange
            int a = 5;
            int b = 27;

            //Act
            var result = _calc.sum(a, b);

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

            //Act
            var result = _calc.FindOddNumbers(start, end);

            //Assert
            Assert.Contains(3, result);
        }

        [Fact]
        public void FindOddNumbersIsNullTest()
        {
            //Arrange
            int start = 1;
            int end = 10;

            //Act
            var result = _calc.FindOddNumbers(start, end);

            //Assert
            //Assert.Null(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void FindOddNumbersSingleTest()
        {
            //Arrange
            int start = 1;
            int end = 2;

            //Act
            var result = _calc.FindOddNumbers(start, end);

            //Assert
            Assert.Single(result);
        }

        [Fact]
        public void FindOddNumbersTypeListTest()
        {
            //Arrange
            int start = 1;
            int end = 2;

            //Act
            var result = _calc.FindOddNumbers(start, end);

            //Assert
            Assert.IsType<List<int>>(result);
        }

        [Fact]
        public void FindOddNumbersIsAssignableFromTest()
        {
            //Arrange
            int start = 1;
            int end = 2;

            //Act
            var result = _calc.FindOddNumbers(start, end);

            //Assert
            Assert.IsAssignableFrom<IEnumerable<int>>(result);
        }

        [Fact]
        public void FindOddNumbersTypeStringTest()
        {
            //Arrange
            int start = 1;
            int end = 2;

            //Act
            var result = _calc.FindOddNumbers(start, end);

            //Assert
            Assert.IsNotType<string>(result);
        }

        [Fact]
        public void FindOddNumbersEmptyTest()
        {
            //Arrange
            int start = 2;
            int end = 5;

            //Act
            var result = _calc.FindOddNumbers(start, end);

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

            //Act
            var result = _calc.IsGreaterThan(a, b);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLessThanTest()
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            var result = _calc.IsLessThan(a, b);

            //Assert
            Assert.True(result);
        }

    }
}
