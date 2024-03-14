using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Izveidojam māju un zemes gabalu objektus
        House myHouse = new House("Brīvības iela 65", 150, 5, "Dzīvokļis");
        LandPlot myLandPlot = new LandPlot("Rīgas iela 56", 500, "Lauksaimniecības zeme");

        // Attēlojam informāciju par māju un zemes gabalu, izmantojot objektu saites
        Console.WriteLine("Informācija par māju:");
        myHouse.DisplayInfo();
        Console.WriteLine("Mājā var dzīvot " + myHouse.GetCapacity() + " cilvēki.");

        Console.WriteLine("\nInformācija par zemes gabalu:");
        myLandPlot.DisplayInfo();

        // Aprēķinām un attēlojam cenu par kvadrātmetru nekustamajam īpašumam
        double housePrice = 150000; // Piemēram, cena par māju
        double landPlotPrice = 50000; // Piemēram, cena par zemes gabalu

        myHouse.CalculatePricePerSquareMeter(housePrice);
        myLandPlot.CalculatePricePerSquareMeter(landPlotPrice);
    }
}
