using System.Text;

namespace Task1
{
    internal class Apartment
    {
        public int Number { get; set; }
        public string Address { get; set; }
        public string Owner { get; set; }
        public ElectricityMeter ElectricityMeter { get; set; }

        public Apartment() : this(0, String.Empty, String.Empty) { }

        public Apartment(int number, string address, string owner) : this(number, address, owner, new ElectricityMeter()) { }

        public Apartment(int number, string address, string owner, ElectricityMeter em)
        {
            Number = number;
            Address = address;
            Owner = owner;

            ElectricityMeter = em;
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Квартира #{Number}, \tВласник:\t{Owner}");
            sb.AppendLine("Показники лічильника:");
            sb.AppendLine(ElectricityMeter.ToString());

            return sb.ToString();
        }

        public bool IsMetricsInQuarter(int quarter)
        {
            if (ElectricityMeter.FirstMonth != null && GetQuarter(ElectricityMeter.FirstMonth.Item1) != quarter)
            {
                return false;
            }

            if (ElectricityMeter.SecondMonth != null && GetQuarter(ElectricityMeter.SecondMonth.Item1) != quarter)
            {
                return false;
            }

            if (ElectricityMeter.ThirdMonth != null && GetQuarter(ElectricityMeter.ThirdMonth.Item1) != quarter)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"Num: {Number}\tAddress: {Address}\t Owner: {Owner}\t ElectricityMeter: {ElectricityMeter}";
        }

        private static int GetQuarter(this DateTime date)
        {
            return (date.Month + 2) / 3;
        }
    }
}
