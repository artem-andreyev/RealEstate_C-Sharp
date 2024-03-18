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
            Console.WriteLine("3. Iziet");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3))
            {
                Console.WriteLine("Lūdzu, ievadiet derīgu izvēles numuru (1, 2 vai 3):");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine(@"
         (
 
           )
         ( _   _._
          |_|-'_~_`-._
       _.-'-_~_-~_-~-_`-._
   _.-'_~-_~-_-~-_~_~-_~-_`-._
  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    |  []  []   []   []  [] |
    |           __    ___   |   
  ._|  []  []  | .|  [___]  |_._._.
  |=|________()|__|()_______|=|=|=|
^^^^^^^^^^^^^^^ === ^^^^^^^^^^^^^^^
    _______      ===   
   <_4sale_>       === 
      ^|^             ===
       |                 ===");
                    DateTime houseListingStartTime = new DateTime(2024, 3, 18);
                    DateTime houseListingEndTime = new DateTime(2024, 3, 30);

                    House myHouse = new House("Brīvības iela 65", 150, 5, "Māja", houseListingStartTime, houseListingEndTime);
                    myHouse.DisplayInfo();
                    Console.WriteLine("Mājā var dzīvot " + myHouse.GetCapacity() + " cilvēki.");

                    double housePrice = 150000;
                    myHouse.CalculatePricePerSquareMeter(housePrice);
                    break;

                case 2:
                    Console.WriteLine(@"
     .-.                                    ,-.
  .-(   )-.                              ,-(   )-.
 (     __) )-.                        ,-(_      __)
  `-(       __)                      (_    )  __)-'
    `(____)-',                        `-(____)-'
  - -  :   :  - -
      / `-' \
    ,    |   .
         .                         _
                                  >')
               _   /              (\\         (W)
              =') //               = \     -. `|'
               ))////)             = ,-      \(| ,-
              ( (///))           ( |/  _______\|/____
~~~~~~~~~~~~~~~`~~~~'~~~~~~~~~~~~~\|,-'::::::::::::::
            _                 ,----':::::::::::::::::
         {><_'c   _      _.--':MJP:::::::::::::::::::
__,'`----._,-. {><_'c  _-':::::::::::::::::::::::::::
:.:.:.:.:.:.:.\_    ,-'.:.:.:.:.:.:.:.:.:.:.:.:.:.:.:
.:.:.:.:.:.:.:.:`--'.:.:.:.:.:.:.:.:.:.:.:.:.:.:.:.:.
.....................................................");
                    DateTime landPlotListingStartTime = new DateTime(2024, 2, 15);
                    DateTime landPlotListingEndTime = new DateTime(2024, 4, 20);

                    LandPlot myLandPlot = new LandPlot("Rīgas iela 56", 500, "Lauksaimniecības zeme", landPlotListingStartTime, landPlotListingEndTime);
                    myLandPlot.DisplayInfo();

                    double landPlotPrice = 50000;
                    myLandPlot.CalculatePricePerSquareMeter(landPlotPrice);
                    break;

                case 3:
                    Console.WriteLine("Programma tiek aizvērta. Uz redzēšanos!");
                    runProgram = false;
                    break;
            }

            if (runProgram)
            {
                Console.WriteLine("\nVai vēlaties turpināt? (Jā / Nē)");
                string continueChoice = Console.ReadLine().ToLower();

                while (continueChoice != "jā" && continueChoice != "nē")
                {
                    Console.WriteLine("Lūdzu, ievadiet derīgu atbildi (Jā / Nē):");
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
