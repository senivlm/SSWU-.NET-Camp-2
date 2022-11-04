using System.Text;

namespace Task1
{
    internal class Buy//Eguals
    {
        public List<Product> Products { get; set; }

        public Buy()
        {
            Products = new List<Product>();
        }

        public Buy(params Product[] products)
        {
            Products = new List<Product>();

            foreach (var product in products)
            {
                Products.Add(product);
            }
        }

        public Buy(List<Product> products)
        {
            Products = products;
        }

        public double CountPrice()
        {
            return Products.Sum(m => m.Price);
        }

        public int CountProduct(string productName)
        {
            return Products.Where(m => m.Name.ToLower() == productName.ToLower()).Count();
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            foreach (var product in Products)
            {
                str.Append($"{product.ToString()}\n");
            }

            return str.ToString();
        }
        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Buy b = (Buy)obj;
                return (Products == b.Products);
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj is Buy list)
            {
                return Products.Count.CompareTo(list.Products.Count);   
            }

            else throw new ArgumentException("Invalid value");
        }

        public int Compare(object? x, object? y)
        {
            if (x is Buy xBuy && y is Buy yBuy)
            {
                return xBuy.CompareTo(yBuy);
            }

            else throw new ArgumentException("Invalid value");
        }
    }
}
