using Task1;

class Program
{// Вітаю. Все доступно.
    static void Main(string[] args)
    {
        Product p1 = new Product("Apple", 10.00, 1.0);
        Product p2 = new Product("Grapes", 20.00, 0.5);
        Product p3 = new Product("Berry", 5.00, 1.0);

        Buy b1 = new Buy(p1, p2, p3);

        var price = b1.CountPrice();

        Check.Print(p1, Console.WriteLine);
        Check.Print(b1, Console.WriteLine);
    }
}
