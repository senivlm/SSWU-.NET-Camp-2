namespace Task1
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Product()
        {
            new Product(String.Empty, default, default);
        }
// Ви зможете покласти і від'ємні величини. А нам цього не треба.
        public Product(string name, double price, double weigth)
        {
            Name = name;
            Price = price;
            Weight = weigth;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\tPrice: {this.Price}$\tWeight: {this.Weight}kg";
        }
    }
}
