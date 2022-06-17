using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    public class Utilities
    {
        public string ConvertRegEx(string regEx) => "^" + regEx;

        public string StartWith(string value, string value2) => value + value2;
    }
}
