using Task4;

class Program
{

    static public void Main(String[] args)
    {
        var tensor0d = new Tensor(1);
        tensor0d.FillRandomValues();
        tensor0d.Print();

        Console.WriteLine(new String('=', 30));

        var tensor1d = new Tensor(10);
        tensor1d.FillRandomValues();
        tensor1d.Print();

        Console.WriteLine(new String('=', 30));

        var tensor2d = new Tensor(4,5);
        tensor2d.FillRandomValues();
        tensor2d.Print();

        Console.WriteLine(new String('=', 30));

        var tensor3d = new Tensor(3,4,5,6);
        tensor3d.FillRandomValues();
        tensor3d.Print();
    }
}