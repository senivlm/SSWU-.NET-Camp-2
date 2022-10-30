namespace Task3
{
    static internal class Cube
    {
        static public int[,,] CreateCube(int xAxis, int yAxis, int zAxis)
        {
            int[,,] cubeArray = new int[xAxis, yAxis, zAxis];

            var rnd = new Random();

            for (int z = 0; z < cubeArray.GetLength(2); z++)
            {
                for (int x = 0; x < cubeArray.GetLength(0); x++)
                {
                    for (int y = 0; y < cubeArray.GetLength(1); y++)
                    {
                        cubeArray[x, y, z] = rnd.Next(2);
                    }
                }
            }

            return cubeArray;
        }

        static public void DisplayCube(this int[,,] cubeArray)
        {
            for (int z = 0; z < cubeArray.GetLength(2); z++)
            {
                for (int x = 0; x < cubeArray.GetLength(0); x++)
                {
                    for (int y = 0; y < cubeArray.GetLength(1); y++)
                    {
                        Console.Write("{0}\t", cubeArray[x, y, z]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        static public bool HasSlot(this int[,,] cubeArray)
        {
            for (int x = 0; x < cubeArray.GetLength(0); x++)
            {
                for (int y = 0; y < cubeArray.GetLength(1); y++)
                {
                    bool hasSlot = true;

                    for (int z = 0; z < cubeArray.GetLength(2); z++)
                    {
                        if (cubeArray[x, y, z] == 1)
                        {
                            hasSlot = false;
                            break;
                        }
                    }
                    if (hasSlot)
                    {
                        return true;
                    }
                }
            }

            for (int z = 0; z < cubeArray.GetLength(2); z++)
            {
                for (int x = 0; x < cubeArray.GetLength(0); x++)
                {
                    bool has = true;

                    for (int y = 0; y < cubeArray.GetLength(1); y++)
                    {
                        if (cubeArray[x, y, z] == 1)
                        {
                            has = false;
                            break;
                        }
                    }
                    if (has)
                    {
                        return true;
                    }
                }
            }

            for (int y = 0; y < cubeArray.GetLength(1); y++)
            {
                for (int z = 0; z < cubeArray.GetLength(2); z++)
                {
                    bool hasSlot = true;

                    for (int x = 0; x < cubeArray.GetLength(0); x++)
                    {
                        if (cubeArray[x, y, z] == 1)
                        {
                            hasSlot = false;
                            break;
                        }
                    }
                    if (hasSlot)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
