using System.Text;

namespace Task1
{
    internal class ElectricityMeter
    {
        public double InputValue { get; set; }
        public Tuple<DateTime, double>? FirstMonth { get; set; }
        public Tuple<DateTime, double>? SecondMonth { get; set; }
        public Tuple<DateTime, double>? ThirdMonth { get; set; }

        public ElectricityMeter() { }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Початковий показник: {InputValue}");

            sb.Append("1:\t");
            sb.Append(FirstMonth != null ? $"{FirstMonth.Item1.ToString("dd.mm.yy")} - {FirstMonth.Item2}" : "-");
            sb.AppendLine();

            sb.Append("2:\t");
            sb.Append(SecondMonth != null ? $"{SecondMonth.Item1.ToString("dd.mm.yy")} - {SecondMonth.Item2}" : "-\t-");
            sb.AppendLine();

            sb.Append("3:\t");
            sb.Append(ThirdMonth != null ? $"{ThirdMonth.Item1.ToString("dd.mm.yy")} - {ThirdMonth.Item2}" : "-\t-");
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
