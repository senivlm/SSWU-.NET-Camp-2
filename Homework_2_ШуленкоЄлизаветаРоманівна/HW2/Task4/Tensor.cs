namespace Task4
{// Молодець. Ще цей клас краще зробити generic(узагальненням!)
    public class Tensor
    {
        private class Dimension
        {
            public int Size;
            public int Stride;
        }

        private double[] _data;

        private Dimension[] _dimensions;

        public readonly int size;

        public Tensor(params int[] sizes)
        {
            size = sizes.Aggregate((a, x) => a * x);

            _dimensions = new Dimension[sizes.Length];

            var stride = size;

            for (var i = 0; i < sizes.Length; i++)
            {
                stride /= sizes[i];

                _dimensions[i] = new Dimension
                {
                    Size = sizes[i],
                    Stride = sizes[i] > 1 ? stride : 0,
                };
            }

            _data = new double[size];
        }

        public void FillRandomValues()
        {
            var rand = new Random();

            for (int i = 0; i < size; i++)
            {
                _data[i] = rand.Next(-100, 100);
            }
        }

        public void Print()
        {
            var indexes = new int[_dimensions.Length];

            RecursivePrint(0, ref indexes);
        }

        private void RecursivePrint(int index, ref int[] indeces)
        {
            if (index >= _dimensions.Length)
            {
                Console.Write($"{GetElement(indeces)}\t");

                return;
            }

            var dimension = _dimensions[index];

            for (int i = 0; i < dimension.Size; i++)
            {
                indeces[index] = i;

                RecursivePrint(index + 1, ref indeces);
            }

            Console.Write(new String('\n', _dimensions.Length - index));
        }

        public double GetElement(params int[] indices)
        {
            long index = 0;

            for (int i = 0; i < indices.Length; i++)
            {
                index += indices[i] * _dimensions[i].Stride;
            }

            return _data[index];
        }
    }
}
