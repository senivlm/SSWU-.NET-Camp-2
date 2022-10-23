namespace Task1
{
    internal static class Check
    {
        public static void Print(Buy buy, Action<string> action)
        {
            action(buy.ToString());
        }

        public static void Print(Product product, Action<string> action)
        {
            action(product.ToString());
        }
    }
}
