using System;

class Program
{
    static void Main()
    {
        bool runProgram = true;

        while (runProgram)
        {
            // Выводим меню выбора недвижимости
            Console.WriteLine("Izvēlieties, ko vēlaties aplūkot:");
            Console.WriteLine("1. Māju");
            Console.WriteLine("2. Zemes gabalu");
            Console.WriteLine("3. Dzīvokli");
            Console.WriteLine("4. Iziet");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 4))
            {
                // Повторяем запрос, пока не будет введено корректное значение
                Console.WriteLine("Lūdzu, ievadiet derīgu izvēles numuru (1, 2, 3 vai 4):");
            }

            switch (choice)
            {
                case 1:
                    // Создаем экземпляр класса House и выводим информацию о нем
                    DateTime houseListingStartTime = new DateTime(2024, 3, 18);
                    DateTime houseListingEndTime = new DateTime(2024, 3, 30);
                    House myHouse = new House("Brīvības iela 65", 150, 5, "Dzīvojamā", houseListingStartTime, houseListingEndTime);
                    Console.WriteLine(myHouse.Drawing());
                    
                    myHouse.DisplayInfo();
                    Console.WriteLine("Mājā var dzīvot " + myHouse.GetCapacity() + " cilvēki.");
                    int housePrice = 150000;
                    myHouse.CalculatePricePerSquareMeter(housePrice);
                    break;

                case 2:
                    // Создаем экземпляр класса LandPlot и выводим информацию о нем
                    DateTime landPlotListingStartTime = new DateTime(2024, 2, 15);
                    DateTime landPlotListingEndTime = new DateTime(2024, 4, 20);
                    LandPlot myLandPlot = new LandPlot("Rīgas iela 56", 500, "Lauksaimniecības zeme", landPlotListingStartTime, landPlotListingEndTime);
                    Console.WriteLine(myLandPlot.Drawing());
                    
                    myLandPlot.DisplayInfo();
                    int landPlotPrice = 50000;
                    myLandPlot.CalculatePricePerSquareMeter(landPlotPrice);
                    break;

                case 3:
                    // Создаем экземпляр класса Apartment и выводим информацию о нем
                    DateTime apartmentListingStartTime = new DateTime(2024, 1, 10);
                    DateTime apartmentListingEndTime = new DateTime(2024, 3, 15);
                    Apartment myApartment = new Apartment("Bruņinieku iela 12", 80, 3, true, apartmentListingStartTime, apartmentListingEndTime);
                    Console.WriteLine(myApartment.Drawing());
                    
                    myApartment.DisplayInfo();
                    Console.WriteLine("Dzīvoklī var dzīvot " + myApartment.GetCapacity() + " cilvēki.");
                    int apartmentPrice = 100000;
                    myApartment.CalculatePricePerSquareMeter(apartmentPrice);
                    break;

                case 4:
                    // Завершаем программу
                    Console.WriteLine("Programma tiek aizvērta. Uz redzēšanos!");
                    runProgram = false;
                    break;
            }

            if (runProgram)
            {
                // Проверяем, желает ли пользователь продолжить
                Console.WriteLine("\nVai vēlaties apskatīt informaciju par nekustamo īpašumu vēlreiz? (Jā / Nē)");
                string continueChoice = Console.ReadLine().ToLower();

                while (continueChoice != "jā" && continueChoice != "nē")
                {
                    // Повторяем запрос, пока не будет введено корректное значение
                    Console.WriteLine("Lūdzu, ievadiet 'Jā' vai 'Nē':");
                    continueChoice = Console.ReadLine().ToLower();
                }

                // Проверяем, если пользователь выбрал "Nē", то завершаем программу
                if (continueChoice == "nē")
                {
                    Console.WriteLine("Programma tiek aizvērta. Uz redzēšanos!");
                    runProgram = false;
                    break; // Завершаем while цикл и программу
                }
            }
        }
    }
}
