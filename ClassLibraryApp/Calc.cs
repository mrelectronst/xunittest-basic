namespace ClassLibraryApp
{
    public class Calc
    {
        public int sum(int a, int b) => a + b;

        public List<int> FindOddNumbers(int start, int end)
        {
            List<int> oddNumbers = new List<int>();

            for (int i = start; i < end; i++)
            {
                if (i%2==1)
                    oddNumbers.Add(i);
            }

            return oddNumbers;
        }
    }
}
