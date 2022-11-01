using System.Text;

namespace Task1
{
    internal class Buy
    {// Порушення інкапсуляції
        public List<Product> Products { get; set; }
        public int Amount { get { return Products.Count; } }

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
            var totalPrice = 0.0;

            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
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
