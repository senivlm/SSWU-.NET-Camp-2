namespace Task2
{
    internal class ArrayHandler
    {
        private int[] _array;

        public ArrayHandler(int arrayLength, int minValue, int maxValue)
        {
            _array = new int[arrayLength];

            FillArrayWithRandoms(minValue, maxValue);
        }

        private void FillArrayWithRandoms(int minValue, int maxValue)
        {
            Random r = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = r.Next(minValue, maxValue);
            }
        }

        public Dictionary<int,int> NumberFrequency()
        {
            return _array.GroupBy(m => m).ToDictionary(m => m.Key, m => m.Count());            
        }

        public void DislayArray()
        {
            foreach (var item in _array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        public void DisplayNumberFrequency(Dictionary<int, int> count)
        {
            foreach (var item in count)
            {
                Console.WriteLine($"Number {item.Key} ocuured {item.Value} times");
            }
        }

        public IEnumerable<List<int>> GetPrimeSequences()
        {
            var sequences = new List<List<int>>();
            var primes = new List<int>();

            foreach (var item in _array)
            {
                if (IsPrime(item))
                {
                    primes.Add(item);
                }
                else
                {
                    if (primes.Count > 0)
                    {
                        sequences.Add(primes);
                    }

                    primes = new List<int>();
                }
            }

            return sequences.OrderByDescending(m => m.Count());
        }

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        static private bool IsPrime(int number, int? i = null)
        {
            if (number == 0)
            {
                return false;
            }

            if (!i.HasValue)
            {
                i = number / 2;
            }

            if (i == 1 || i == 0)
            {
                return true;
            }
            else
            {
                return number % i == 0 ? false : IsPrime(number, i - 1);
            }
        }
    }
}
