using Task1;

class Program
{
    static public void Main(String[] args)
    {
        Storage storage = new Storage();

        var listProducts = new List<Product>() 
        {
            new Product("Tomato", 6.75, 5),
            new Product("Potato", 9.75, 7),
            new Product("Apple", 3.5, 2),
            new Product("Cucumber", 5, 2),
            new Meat(Category.Sort1, Type.Pork, "Meat", 20, 1),
            new Meat(Category.Extra, Type.Lamb, "Meat", 25.90, 0.5)
        };

        storage.FillStorageWithUser();
        storage.FillStorage(listProducts);
        storage.DisplayProducts();

        var searchedProduct = storage.GetProductByIndex(3);
        var meatList = storage.FindAllMeatProducts();
    }
}