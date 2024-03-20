// абстрактный класс нельзя использовать напрямую, а только в наследниках, нужен для того чтобы описать нечто абстрактное
// protected объявляет метод или свойство защищенными (похоже на private), protected: такой класс доступен из любого места в текущем классе или в производных от него классах
// virtual - для того чтобы иметь возможность переопределить какой-то метод, который находится в базовом классе, без virtual новую реализацию (перепись кода) мы сделать не можем
// virtual - предполагает наличие реализации, которую при необходимости/желании можно переопределить. abstract вы обязаны реализовать в неабстрактном классе. никакой реализации по умолчанию не предполагается.

using System;

// Определяем абстрактный класс для недвижимости
public abstract class RealEstate
{
    // Защищенные поля для адреса, площади и времени размещения
    protected string address;
    protected double area;
    protected DateTime listingStartTime;
    protected DateTime listingEndTime;

    // Конструктор для установки базовых значений
    public RealEstate(string address, double area, DateTime listingStartTime, DateTime listingEndTime)
    {
        this.address = address;
        this.area = area;
        this.listingStartTime = listingStartTime;
        this.listingEndTime = listingEndTime;
    }

    // Конструктор с базовыми значениями времени размещения
    public RealEstate(string address, double area) : this(address, area, DateTime.MinValue, DateTime.MinValue) { }

    // Абстрактные методы, которые должны быть реализованы в подклассах
    public abstract void DisplayInfo();
    public virtual string GetDescription()
    {
        return "Māja atrodas adresē: Rīgas iela 21, ar kopējo platību 85 kvadrātmetri.";
    }
    public abstract int GetCapacity();
    public abstract void CalculatePricePerSquareMeter(double price);
    public virtual string Drawing()
    {
        return @"           x
.-. _______|
|=|/     /  \
| |_____|_""_|
|_|_[X]_|____|";
    }

    // Методы для установки и получения времени размещения
    public void SetListingStartTime(DateTime startTime)
    {
        this.listingStartTime = startTime;
    }

    public void SetListingEndTime(DateTime endTime)
    {
        this.listingEndTime = endTime;
    }

    public DateTime GetListingStartTime()
    {
        return this.listingStartTime;
    }

    public DateTime GetListingEndTime()
    {
        return this.listingEndTime;
    }
}

// Класс для домов
public class House : RealEstate
{
    private int numberOfRooms;
    private string landType;

    // Конструкторы для установки значений
    public House(string address, double area, int numberOfRooms, string landType, DateTime listingStartTime, DateTime listingEndTime) : base(address, area, listingStartTime, listingEndTime)
    {
        this.numberOfRooms = numberOfRooms;
        this.landType = landType;
    }

    public House(string address, double area, int numberOfRooms, string landType) : base(address, area)
    {
        this.numberOfRooms = numberOfRooms;
        this.landType = landType;
    }

    // Реализация абстрактных методов
    public override void DisplayInfo()
    {
        Console.WriteLine("Māja atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri.");
        Console.WriteLine("Tajā ir " + numberOfRooms + " istabas.");
        Console.WriteLine("Tas ir " + landType);
        Console.WriteLine("Izlikšanas sākuma laiks: " + listingStartTime);
        Console.WriteLine("Izlikšanas beigu laiks: " + listingEndTime);
    }

    public override string GetDescription()
    {
        return "Māja atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri. Tajā ir " + numberOfRooms + " istabas.";
    }

    public override int GetCapacity()
    {
        return numberOfRooms * 2;
    }

    public override void CalculatePricePerSquareMeter(double price)
    {
        double pricePerSquareMeter = price / area;
        Console.WriteLine("Cena par kvadrātmetru mājai ir: " + pricePerSquareMeter + " EUR.");
    }

    public override string Drawing()
    {
        return @"
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
       |                 ===";
    }
}

// Класс для земельных участков
public class LandPlot : RealEstate
{
    private string landType;

    // Конструкторы для установки значений
    public LandPlot(string address, double area, string landType, DateTime listingStartTime, DateTime listingEndTime) : base(address, area, listingStartTime, listingEndTime)
    {
        this.landType = landType;
    }

    public LandPlot(string address, double area, string landType) : base(address, area)
    {
        this.landType = landType;
    }

    // Реализация абстрактных методов
    public override void DisplayInfo()
    {
        Console.WriteLine("Zemes gabals atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri.");
        Console.WriteLine("Tas ir " + landType + " tips zemes.");
        Console.WriteLine("Izlikšanas sākuma laiks: " + listingStartTime);
        Console.WriteLine("Izlikšanas beigu laiks: " + listingEndTime);
    }

    public override string GetDescription()
    {
        return "Zemes gabals atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri. Tas ir " + landType + " tips zemes.";
    }

    public override int GetCapacity()
    {
        return 0;
    }

    public override void CalculatePricePerSquareMeter(double price)
    {
        double pricePerSquareMeter = price / area;
        Console.WriteLine("Cena par kvadrātmetru zemes gabalam ir: " + pricePerSquareMeter + " EUR.");
    }

    public override string Drawing()
    {
        return @"
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
.:.:.:.:.:.:.:.:`--'.:.:.:.:.:.:.:.:.:.:.:.:.:.:.:.
.....................................................";
    }
}

// Класс для квартир
public class Apartment : RealEstate
{
    private int numberOfRooms;
    private bool hasBalcony;

    // Конструктор для установки значений
    public Apartment(string address, double area, int numberOfRooms, bool hasBalcony, DateTime listingStartTime, DateTime listingEndTime) 
        : base(address, area, listingStartTime, listingEndTime)
    {
        this.numberOfRooms = numberOfRooms;
        this.hasBalcony = hasBalcony;
    }

    // Реализация абстрактных методов
    public override void DisplayInfo()
    {
        Console.WriteLine("Dzīvoklis atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri.");
        Console.WriteLine("Dzīvoklī ir " + numberOfRooms + " istabas.");
        Console.WriteLine("Balkons: " + (hasBalcony ? "Jā" : "Nē"));
        Console.WriteLine("Izlikšanas sākuma laiks: " + listingStartTime);
        Console.WriteLine("Izlikšanas beigu laiks: " + listingEndTime);
    }

    public override string GetDescription()
    {
        return "Dzīvoklis atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri. Dzīvoklī ir " + numberOfRooms + " istabas.";
    }

    public override int GetCapacity()
    {
        return numberOfRooms * 2;
    }

    public override void CalculatePricePerSquareMeter(double price)
    {
        double pricePerSquareMeter = price / area;
        Console.WriteLine("Cena par kvadrātmetru dzīvoklim ir: " + pricePerSquareMeter + " EUR.");
    }
public override string Drawing()
    {
    return @"
0================================================0
|'.                    (|)                     .'|
|  '.                   |                    .'  |
|    '.                |O|                 .'    |
|      '. ____________/===\_____________ .'      |
|        :            `\""\`  ______     :     ..|
|        :     mmmmmmm  V   |--%%--|    :   .'|| |
|        :     |  |  |      |-%%%%-|    :  |  || |
|        :     |--|--| @@@  |=_||_=|    :  I  || |
|        :     |__|__|@@@@@ |_\__/_|    :  |  || |
|        :             \|/   ____       :  |  || |
|        :;;       .'``(_)```\__/````:  :  |  || |
|        :||___   :================:'|  :  | 0+| |
|        :||===)  | |              | |  :  |  || |
|        ://``\\__|_|______________|_|__:  I  || |
|      .'/'    \\' | '              | '   '|  || |
|    .'           |                |       '. || |
|  .'                                        '|| |
|.'                                            '.|
0================================================0";
    }
}