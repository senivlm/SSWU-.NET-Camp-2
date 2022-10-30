using Task3;

class Program
{

    static public void Main(String[] args)
    {
        var resultArray = Cube.CreateCube(5, 5, 5);

        Cube.DisplayCube(resultArray);

        var result = Cube.HasSlot(resultArray);
    }
}