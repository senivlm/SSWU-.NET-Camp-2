using System.Globalization;

namespace Task1
{
    internal static class ApartmentUtillity
    {
        private static CultureInfo _cultureInfo = new CultureInfo("uk-UA");

        public static Apartment? CreateApartment(string line)
        {
            var data = line.Split('|');

            if (!int.TryParse(data[0], out int number)
                || !int.TryParse(data[3], out int inputValue))
            {
                return null;
            }

            var apartment = new Apartment(number, data[1], data[2]);

            apartment.ElectricityMeter.InputValue = inputValue;

            var firstMonth = ParseElectricyMetric(data[4], data[5]);

            if (firstMonth != null)
            {
                apartment.ElectricityMeter.FirstMonth = firstMonth;
            }

            var secondMonth = ParseElectricyMetric(data[6], data[7]);

            if (secondMonth != null)
            {
                apartment.ElectricityMeter.SecondMonth = secondMonth;
            }

            var thirdMonth = ParseElectricyMetric(data[8], data[9]);

            if (firstMonth != null)
            {
                apartment.ElectricityMeter.ThirdMonth = thirdMonth;
            }

            return apartment;
        }

        private static Tuple<DateTime, double>? ParseElectricyMetric(string dateString, string mectricString)
        {
            if (DateTime.TryParse(dateString ?? String.Empty, _cultureInfo, DateTimeStyles.None, out DateTime date)
                && Double.TryParse(mectricString ?? String.Empty, out double metric))
            {
                return new Tuple<DateTime, double>(date, metric);
            }

            return null;
        }
    }
}
