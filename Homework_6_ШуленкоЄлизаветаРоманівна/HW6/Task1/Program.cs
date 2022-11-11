using Task1;

class Program
{
    static public void Main(String[] args)
    {
        var quarter = 1;

        var apartments = FileUtillity.GetApartmentsPerQuarter(quarter);

        FileUtillity.FillReportFile();
    }
}