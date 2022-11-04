using Task2;

class Program
{
    static public void Main(String[] args)
    {
        ArrayHandler ah = new ArrayHandler(20, 0, 10);

        ah.DislayArray();
       
        ah.DisplayNumberFrequency(ah.NumberFrequency());

        var longeatSequences = ah.GetPrimeSequences();
    }
}