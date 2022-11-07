using Task1;

class Program
{
    static public void Main(String[] args)
    {
        Storage storage = new Storage();

        var listProducts = new List<Product>()
        {
            new Product("Tomato", 6.75, Measure.Kilogram, 2),
            new Product("Potato", 9.75, Measure.Kilogram, 7),
            new Product("Apple", 3.5, Measure.Kilogram, 2),
            new Product("", 5, Measure.Kilogram, 2),
            new Meat(Category.Sort1, Type.Pork, "Meat", 20, Measure.Kilogram, 1),
            new Meat(Category.Extra, Type.Lamb, "Meat", 25.90, Measure.Kilogram, 0.5),
            new DairyProducts("Milk", 1.25, Measure.Liter, 1, new DateTime(2023, 5, 1, 8, 30, 52)),
            new DairyProducts("Heavy cream", 2, Measure.Kilogram, 0.3, new DateTime(2023, 2, 20, 21, 30, 52))
        };

        Basket b = new Basket(Currency.Dollar, listProducts);

        var currency = storage.GetProductsCurrency();
        storage.FillStorageWithUser();
        storage.FillStorage(listProducts);
        storage.DisplayProducts();

        Basket b2 = new Basket(currency, storage.GetProductByIndex(3), storage.GetProductByIndex(5), storage.GetProductByIndex(1));

        var searchProduct = storage.GetProductByIndex(3);
        var meatList = storage.FindAllMeatProducts();

        var m1 = new Meat(Category.Sort1, Type.Pork, "Meat", 20, Measure.Kilogram, 1);
        var m2 = new Meat(Category.Extra, Type.Lamb, "Meat", 25.90, Measure.Kilogram, 0.5);

        var result = m1.CompareTo(m2);
    }
}