using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("Izvēlieties, ko vēlaties aplūkot:");
            Console.WriteLine("1. Māju");
            Console.WriteLine("2. Zemes gabalu");
            Console.WriteLine("3. Dzīvokli");
            Console.WriteLine("4. Iziet");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 4))
            {
                Console.WriteLine("Lūdzu, ievadiet derīgu izvēles numuru (1, 2, 3 vai 4):");
            }

            switch (choice)
            {
                case 1:
                    DateTime houseListingStartTime = new DateTime(2024, 3, 18);
                    DateTime houseListingEndTime = new DateTime(2024, 3, 30);

                    House myHouse = new House("Brīvības iela 65", 150, 5, "Dzīvojamā", houseListingStartTime, houseListingEndTime);
                    myHouse.DisplayInfo();
                    Console.WriteLine("Mājā var dzīvot " + myHouse.GetCapacity() + " cilvēki.");

                    int housePrice = 150000;
                    myHouse.CalculatePricePerSquareMeter(housePrice);
                    break;

                case 2:
                    DateTime landPlotListingStartTime = new DateTime(2024, 2, 15);
                    DateTime landPlotListingEndTime = new DateTime(2024, 4, 20);

                    LandPlot myLandPlot = new LandPlot("Rīgas iela 56", 500, "Lauksaimniecības zeme", landPlotListingStartTime, landPlotListingEndTime);
                    myLandPlot.DisplayInfo();

                    int landPlotPrice = 50000;
                    myLandPlot.CalculatePricePerSquareMeter(landPlotPrice);
                    break;

                case 3:
                    DateTime apartmentListingStartTime = new DateTime(2024, 1, 10);
                    DateTime apartmentListingEndTime = new DateTime(2024, 3, 15);

                    Apartment myApartment = new Apartment("Bruņinieku iela 12", 80, 3, true, apartmentListingStartTime, apartmentListingEndTime);
                    myApartment.DisplayInfo();
                    Console.WriteLine("Dzīvoklī var dzīvot " + myApartment.GetCapacity() + " cilvēki.");

                    int apartmentPrice = 100000;
                    myApartment.CalculatePricePerSquareMeter(apartmentPrice);
                    break;

                case 4:
                    Console.WriteLine("Programma tiek aizvērta. Uz redzēšanos!");
                    runProgram = false;
                    break;
            }

            if (runProgram)
            {
                Console.WriteLine("\nVai vēlaties apskatīt informaciju par nekustamo īpašumu vēlreiz? (Jā / Nē)");
                string continueChoice = Console.ReadLine().ToLower();

                while (continueChoice != "jā" && continueChoice != "nē")
                {
                    Console.WriteLine("Lūdzu, ievadiet 'Jā' vai 'Nē':");
                    continueChoice = Console.ReadLine().ToLower();
                }

                if (continueChoice == "nē")
                {
                    Console.WriteLine("Programma tiek aizvērta. Uz redzēšanos!");
                    runProgram = false;
                }
            }
        }
    }
}