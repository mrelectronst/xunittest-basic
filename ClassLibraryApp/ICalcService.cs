using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    public interface ICalcService
    {
        int Multiply(int x, int y);
        int Sum(int x, int y);
    }
}
