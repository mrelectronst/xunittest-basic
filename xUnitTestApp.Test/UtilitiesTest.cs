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
        [Fact]
        public void ConvertRegExTest()
        {
            //Arrange
            string regEx = "dog";
            string regEx2 = "dog fth";
            var utilities = new Utilities();

            //Act
            var result = utilities.ConvertRegEx(regEx);

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
            var utilities = new Utilities();

            //Act
            var result = utilities.StartWith(value,value2);

            //Assert
            Assert.StartsWith(value, result);
            //Assert.EndsWith(value, result);
        }
    }
}
