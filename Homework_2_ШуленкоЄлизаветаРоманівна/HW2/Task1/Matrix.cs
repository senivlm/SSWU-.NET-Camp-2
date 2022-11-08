namespace Task1
{
    static internal class Matrix
    {
        public static int[,] CreateSnakedMatrix(int rowCount, int columnCount, int firstNum)
        {
            int[,] array = new int[rowCount, columnCount];

            for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {//Можна оптимальніше
                if (columnIndex % 2 == 0)
                {
                    for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                    {
                        array[rowIndex, columnIndex] = firstNum;

                        firstNum++;
                    }
                }
                else
                {
                    for (int rowIndex = rowCount - 1; rowIndex >= 0; rowIndex--)
                    {
                        array[rowIndex, columnIndex] = firstNum;

                        firstNum++;
                    }
                }
            }

            return array;
        }

        public static int[,] CreateSnakedMatrixReverse(int rowCount, int columnCount, int firstNum)
        {
            int[,] array = new int[rowCount, columnCount];

            for (int columnIndex = columnCount - 1; columnIndex >= 0; columnIndex--)
            {
                if (columnIndex % 2 == 0)
                {
                    for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                    {
                        array[rowIndex, columnIndex] = firstNum;

                        firstNum++;
                    }
                }
                else
                {

                    for (int rowIndex = rowCount - 1; rowIndex >= 0; rowIndex--)
                    {
                        array[rowIndex, columnIndex] = firstNum;

                        firstNum++;
                    }
                }
            }

            return array;
        }

        public static int[,] CreateDiagonalSnakedMatrix(int length, int firstNum)
        {
            int[,] array = new int[length, length];

            var row = 0;
            var column = 0;

            for (int i = 0; i < length * length; i++)
            {
                array[row, column] = firstNum++;

                if ((row + column) % 2 == 0)
                {
                    if (column < length - 1)
                    {
                        column++;

                        if (row > 0)
                        {
                            row--;
                        }
                    }
                    else
                    {
                        row++;
                    }
                }
                else
                {
                    if (row < length - 1)
                    {
                        row++;

                        if (column > 0)
                        {
                            column--;
                        }
                    }
                    else
                    {
                        column++;
                    }
                }
            }

            return array;
        }

        public static int[,] CreateDiagonalSnakedReverseMatrix(int length, int firstNum)
        {
            int[,] array = new int[length, length];

            var row = length - 1;
            var column = length - 1;

            for (int i = 0; i < length * length; i++)
            {
                array[row, column] = firstNum++;

                if ((row + column) % 2 == 0)
                {
                    if (column > 0)
                    {
                        column--; 
                        
                        if (row < length - 1)
                        {
                            row++;
                        }
                    }
                    else
                    {
                        row--;
                    }
                }
                else
                {
                    if (row > 0)
                    {
                        row--;

                        if (column < length - 1)
                        {
                            column++;
                        }
                    }
                    else
                    {
                        column--;
                    }
                }
            }

            return array;
        }
        public static int[,] CreateSpiralMatrix(int rowCount, int columnCount, int firstNum)
        {
            int[,] array = new int[rowCount, columnCount];

            int row = 0, column = 0;

            int maxColumn = columnCount - 1;
            int maxRow = rowCount - 1;
            int min = 0;

            for (int i = 1; i <= rowCount * columnCount; i++)
            {
                array[row, column] = firstNum;

                if (column == maxColumn && row != min)
                    row--;
                else if (row == maxRow)
                    column++;
                else if (column == min)
                    row++;
                else if (row == min && column != min + 1)
                    column--;
                else
                {
                    maxColumn -= 1;
                    maxRow -= 1;
                    min += 1;
                    row++;
                }

                firstNum++;
            }

            return array;
        }

        public static int[,] CreateSpiralReverseMatrix(int rowCount, int columnCount, int firstNum)
        {
            int[,] array = new int[rowCount, columnCount];

            int row = rowCount - 1, column = columnCount - 1;

            int maxColumn = columnCount - 1;
            int maxRow = rowCount - 1;
            int min = 0;

            for (int i = 1; i <= rowCount * columnCount; i++)
            {
                array[row, column] = firstNum;

                if (row == min && column != maxColumn)
                    column++;
                else if (column == min)
                    row--;
                else if (row == maxRow)
                    column--;
                else if (column == maxColumn && row != min + 1)
                    row++;                
                
                else
                {
                    maxColumn -= 1;
                    maxRow -= 1;
                    min += 1;
                    row++;
                }

                firstNum++;
            }

            return array;
        }

        public static void DisplayMatrix(this int[,] array)
        {
            var rowLength = array.GetLength(0);
            var columnLength = array.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
