using System;

public abstract class RealEstate
{
    protected string address;
    protected double area;
    protected DateTime listingStartTime;
    protected DateTime listingEndTime;

    public RealEstate(string address, double area, DateTime listingStartTime, DateTime listingEndTime)
    {
        this.address = address;
        this.area = area;
        this.listingStartTime = listingStartTime;
        this.listingEndTime = listingEndTime;
    }

    public RealEstate(string address, double area) : this(address, area, DateTime.MinValue, DateTime.MinValue) { }

    public abstract void DisplayInfo();

    public abstract string GetDescription();

    public abstract int GetCapacity();

    public abstract void CalculatePricePerSquareMeter(double price);

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

public class House : RealEstate
{
    private int numberOfRooms;
    private string landType;

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
}

public class LandPlot : RealEstate
{
    private string landType;

    public LandPlot(string address, double area, string landType, DateTime listingStartTime, DateTime listingEndTime) : base(address, area, listingStartTime, listingEndTime)
    {
        this.landType = landType;
    }

    public LandPlot(string address, double area, string landType) : base(address, area)
    {
        this.landType = landType;
    }

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
}

public class Apartment : RealEstate
{
    private int numberOfRooms;
    private bool hasBalcony;

    public Apartment(string address, double area, int numberOfRooms, bool hasBalcony, DateTime listingStartTime, DateTime listingEndTime) 
        : base(address, area, listingStartTime, listingEndTime)
    {
        this.numberOfRooms = numberOfRooms;
        this.hasBalcony = hasBalcony;
    }

    public Apartment(string address, double area, int numberOfRooms, bool hasBalcony) 
        : base(address, area)
    {
        this.numberOfRooms = numberOfRooms;
        this.hasBalcony = hasBalcony;
    }

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
}
