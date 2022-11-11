using Task1;

class Program
{
    static public void Main(String[] args)
    {
        var quarter = 1;

        var apartments = FileUtillity.GetApartmentsPerQuarter(quarter);

        FileUtillity.FillReportFile(apartments, quarter);

        var debtors = ApartmentUtillity.FindDebtors(apartments);
        var mostDebt = debtors.FirstOrDefault();

        FileUtillity.FillReportFile(mostDebt, quarter, "debtors");

        var unusedApartments = ApartmentUtillity.FindUnusedApartments(apartments);

        FileUtillity.FillReportFile(unusedApartments, quarter, "unused");
    }
}