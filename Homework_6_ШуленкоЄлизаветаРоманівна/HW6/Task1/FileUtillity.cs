using System.Globalization;
using System.Text;

namespace Task1
{
    internal static class FileUtillity
    {
        private static readonly string _inputFolderPath = @".\Input";
        private static readonly string _outputFolderPath = @".\Output";

        private static CultureInfo _cultureInfo = new CultureInfo("uk-UA");
        private static DateTimeFormatInfo _dateTimeFormatInfo = _cultureInfo.DateTimeFormat;

        public static List<Apartment> GetApartmentsPerQuarter(int quarter)
        {
            var apartments = new List<Apartment>();

            var inputFilePathes = Directory.GetFiles(_inputFolderPath);

            foreach (var filePath in inputFilePathes)
            {
                apartments.AddRange(GetApartmentsFromFile(filePath, quarter));
            }

            return apartments;
        }

        public static List<Apartment> GetApartmentsFromFile(string filePath, int quarter)
        {
            var result = new List<Apartment>();

            if (!File.Exists(filePath))
            {
                return result;
            }

            var fileData = File.ReadLines(filePath);
            var infoString = fileData.First();

            var quarterString = infoString.Split('|')[1].Trim();

            if (quarterString != quarter.ToString())
            {
                return result;
            }

            foreach (string line in fileData.Skip(1))
            {
                var apartment = ApartmentUtillity.CreateApartment(line);

                if (apartment != null && apartment.IsMetricsInQuarter(quarter))
                {
                    result.Add(apartment);
                }
            }

            return result;
        }

        public static void FillReportFile(List<Apartment> apartments, int quarter, string? fileName = null)
        {
            var report = GetQuarterReport(apartments, quarter);

        }

        public static string GetQuarterReport(List<Apartment> apartments, int quarter)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Звіт за квартал {quarter}\n");

            sb.AppendLine($"Місяць: {_dateTimeFormatInfo.MonthGenitiveNames[quarter]} - {_dateTimeFormatInfo.MonthGenitiveNames[quarter + 2]}\n\n");

            foreach (var apartment in apartments)
            {
                sb.AppendLine(apartment.GetInfo());
            }

            return sb.ToString();
        }
    }
}
