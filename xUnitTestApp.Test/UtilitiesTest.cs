using ClassLibraryApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestApp.Test
{
    public class UtilitiesTest
    {
        private readonly Utilities _utilities;
        public UtilitiesTest()
        {
            _utilities = new Utilities();
        }

        [Fact]
        public void ConvertRegExTest()
        {
            //Arrange
            string regEx = "dog";
            string regEx2 = "dog fth";

            //Act
            var result = _utilities.ConvertRegEx(regEx);

            //Assert
            Assert.Matches(result, regEx2);
            //Assert.DoesNotMatch(result, regEx2);
        }

        [Fact]
        public void StartWithTest()
        {
            //Arrange
            string value = "fth";
            string value2 = "krm";

            //Act
            var result = _utilities.StartWith(value,value2);

            //Assert
            Assert.StartsWith(value, result);
            //Assert.EndsWith(value, result);
        }
    }
}
