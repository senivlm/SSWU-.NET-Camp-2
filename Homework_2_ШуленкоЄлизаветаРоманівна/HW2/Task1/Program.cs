using Task1;

class Program
{

    static public void Main(String[] args)
    {
        int[,] snakeMatrix = Matrix.CreateSnakedMatrix(3, 4, 1);
        snakeMatrix.DisplayMatrix();

        int[,] snakeMatrixReverse = Matrix.CreateSnakedMatrixReverse(3, 4, 1);
        snakeMatrixReverse.DisplayMatrix();

        Console.WriteLine(new string('=',50));

        int[,] diagonalMatrix = Matrix.CreateDiagonalSnakedMatrix(4, 1);
        diagonalMatrix.DisplayMatrix();

        int[,] diagonaReverselMatrix = Matrix.CreateDiagonalSnakedReverseMatrix(4, 1);
        diagonaReverselMatrix.DisplayMatrix();

        Console.WriteLine(new string('=', 50));

        int[,] spiralMatrix = Matrix.CreateSpiralMatrix(6, 7, 1);
        spiralMatrix.DisplayMatrix();

        int[,] spiralReverseMatrix = Matrix.CreateSpiralReverseMatrix(6, 7, 1);
        spiralReverseMatrix.DisplayMatrix();
    }
}