namespace ClassLibraryApp
{
    public class Calc
    {
        private readonly ICalcService _calcService;

        public Calc(ICalcService calcService)
        {
            _calcService = calcService;
        }

        public int sum(int a, int b) => _calcService.Sum(a, b);

        public int multiply(int a, int b) => _calcService.Multiply(a, b);

        public List<int> FindOddNumbers(int start, int end)
        {
            List<int> oddNumbers = new List<int>();

            for (int i = start; i < end; i++)
            {
                if (i % 2 == 1)
                    oddNumbers.Add(i);
            }

            return oddNumbers;
        }

        public bool IsGreaterThan(int a, int b) => a > b;

        public bool IsLessThan(int a, int b) => a < b;
    }
}
