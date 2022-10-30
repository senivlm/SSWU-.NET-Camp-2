using Task1;

class Program
{

    static public void Main(String[] args)
    {
        int[,] snakeMatrix = Matrix.CreateSnakedMatrix(3, 4, 1);
        snakeMatrix.DisplayMatrix();

        int[,] diagonalMatrix = Matrix.CreateDiagonalSnakedMatrix(4, 1);
        diagonalMatrix.DisplayMatrix();

        int[,] spiralMatrix = Matrix.CreateSpiralMatrix(5, 6, 1);
        spiralMatrix.DisplayMatrix();

    }
}