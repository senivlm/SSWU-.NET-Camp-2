namespace Task1
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, double weigth)
        {
            Name = name;
            Price = price;
            Weight = weigth;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tPrice: {Price}$\tWeight: {Weight}kg";
        }
    }
}
