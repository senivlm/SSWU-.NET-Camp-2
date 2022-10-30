namespace Task2
{
    static internal class PixelMatrix
    {
        static public int[,] CreateMatrix(int rowCount, int columnCount)
        {
            Random rnd = new Random();

            int[,] array = new int[rowCount, columnCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    array[row, column] = rnd.Next(0, 17);
                }
            }

            return array;
        }

        static public void DisplayMatrix(this int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }

                Console.WriteLine();
            }
        }

        static public void DisplayLongestSequence(this int[,] array)
        {
            var rowLength = array.GetLength(0);
            var columnLength = array.GetLength(1);

            List<Sequence> sequences = new List<Sequence>();

            int? value = null;
            int startIndex = 0;
            int count = 0;

            for (int row = 0; row < rowLength; row++)
            {
                for (int column = 0; column < columnLength; column++)
                {
                    if (value != array[row, column])
                    {
                        if (value.HasValue)
                        {
                            sequences.Add(new Sequence
                            {
                                Value = value.Value,
                                StartIndex = startIndex,
                                Count = count
                            });
                        }

                        value = array[row, column];
                        startIndex = column;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }

                sequences.Add(new Sequence
                {
                    Value = value.Value,
                    StartIndex = startIndex,
                    Count = count
                });

            }

            var longestSequence = sequences.OrderByDescending(m => m.Count).First();

            Console.WriteLine($"\nColor: {longestSequence.Value}\nStart index: {longestSequence.StartIndex}\nEnd index: {longestSequence.StartIndex + longestSequence.Count - 1}\nLength {longestSequence.Count}");
        }
    }
}
