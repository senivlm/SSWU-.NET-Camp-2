namespace Task1
{
    internal class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Product() : this(String.Empty, default, default) { }

        public Product(string name, double price, double weigth)
        {
            Name = name;
            Price = price;
            Weight = weigth;
        }

        public virtual void ChangePrice(double percent)
        {
            Price += (Price * percent / 100);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\tPrice: {this.Price}$\tWeight: {this.Weight}kg";
        }

        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Product p = (Product)obj;
                return (Name == p.Name && Price == p.Price && Weight == p.Weight);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight);
        }
    }
}
