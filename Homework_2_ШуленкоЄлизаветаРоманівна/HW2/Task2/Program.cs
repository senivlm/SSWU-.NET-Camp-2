using Task2;

class Program
{

    static public void Main(String[] args)
    {
        int[,] result = PixelMatrix.CreateMatrix(10, 30);

        result.DisplayMatrix();

        result.DisplayLongestSequence();

    }
}