using Task1;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Apple", 10.00, 1.0);
        Product p2 = new Product("Grapes", 20.00, 0.5);
        Product p3 = new Product("Berry", 5.00, 1.0);
        Product p4 = new Product("OliveOil", 2.00, 0.5);
        Product p5 = new Product("OliveOil", 2.00, 0.5);

        Buy b1 = new Buy(p1, p2, p3, p4, p5);

        var price = b1.CountPrice();
        Console.WriteLine($"Total price {price}");

        var productName = "OliveOil";
        var oilAmount = b1.CountProduct(productName);
        Console.WriteLine($"Amount of {productName}: {oilAmount}");

        Check.Print(p1, Console.WriteLine);
        Check.Print(b1, Console.WriteLine);
    }
}