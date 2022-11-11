using System.Text;

namespace Task1
{
    internal class ElectricityMeter
    {
        public const double WATT_PRICE = 1.44;

        public double InputValue { get; set; }
        public Tuple<DateTime, double>? FirstMonth { get; set; }
        public Tuple<DateTime, double>? SecondMonth { get; set; }
        public Tuple<DateTime, double>? ThirdMonth { get; set; }

        public ElectricityMeter() { }

        public string GetInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Початковий показник: {InputValue}");

            sb.Append("1: ");
            sb.Append(FirstMonth != null ? $"{FirstMonth.Item1.ToString("dd.MM.yy")} - {FirstMonth.Item2}" : "-");
            sb.AppendLine();

            sb.Append("2: ");
            sb.Append(SecondMonth != null ? $"{SecondMonth.Item1.ToString("dd.MM.yy")} - {SecondMonth.Item2}" : "-\t-");
            sb.AppendLine();

            sb.Append("3: ");
            sb.Append(ThirdMonth != null ? $"{ThirdMonth.Item1.ToString("dd.MM.yy")} - {ThirdMonth.Item2}" : "-\t-");
            sb.AppendLine();

            return sb.ToString();

        }

        public double GetTotalPrice()
        {
            if (ThirdMonth != null)
            {
                return (ThirdMonth.Item2 - InputValue) * WATT_PRICE;
            }

            if (SecondMonth != null)
            {
                return (SecondMonth.Item2 - InputValue) * WATT_PRICE;
            }

            if (FirstMonth != null)
            {
                return (FirstMonth.Item2 - InputValue) * WATT_PRICE;
            }

            return 0;
        }

        public override string ToString() => $"Input {InputValue}";
    }
}
