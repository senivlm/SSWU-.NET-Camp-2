using System.Text;

namespace Task1
{
    internal class Buy
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
    }
}
