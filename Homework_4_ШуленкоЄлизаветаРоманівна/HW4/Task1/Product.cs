using System.Collections;

namespace Task1
{// не правильна реалізація IComparer
    internal class Product : IComparer, IComparable
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
        
        public int CompareTo(object? obj)
        {
            if (obj is Product product)
            {
                int result = Name.CompareTo(product.Name);

                if (result != 0) return result;

                result = Price.CompareTo(product.Price);

                if (result != 0) return result;

                result = Weight.CompareTo(product.Weight);

                return result;
            }
            else throw new ArgumentException("Invalid value");
        }

        public int Compare(object? x, object? y)
        {
            if (x is Product xProduct && y is Product yProduct)
            {
                return xProduct.CompareTo(yProduct);
            }
            else throw new ArgumentException("Invalid value");
        }
    }
}
