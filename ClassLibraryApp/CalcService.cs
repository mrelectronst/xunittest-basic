using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    public class CalcService : ICalcService
    {
        public int Sum(int x, int y) => x + y;

        public int Multiply(int x, int y) => x * y;
    }
}
