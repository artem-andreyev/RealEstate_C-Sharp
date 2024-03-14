using System;

// Abstraktais klases apraksts
public abstract class RealEstate
{
    // Adrese nekustamajam īpašumam
    protected string address;

    // Platība kvadrātmetros
    protected double area;

    // Konstruktors, lai inicializētu nekustamā īpašuma adresi un platību
    public RealEstate(string address, double area)
    {
        this.address = address;
        this.area = area;
    }

    // Abstraktā metode, kas jāpārdefinē apakšklasēs
    public abstract void DisplayInfo();

    // Abstraktā metode, kas jāpārdefinē apakšklasēs
    public abstract string GetDescription();
}

// Klase "Māja", kas manto "Nekustamais īpašums"
public class House : RealEstate
{
    // Istabu skaits
    private int numberOfRooms;
    private string landType; // Pieliku landType kā privāto lauku

    // Konstruktors, kas izsauc vecāko klases konstruktoru un inicializē istabu skaitu un zemes gabala tipu
    public House(string address, double area, int numberOfRooms, string landType) : base(address, area)
    {
        this.numberOfRooms = numberOfRooms;
        this.landType = landType;
    }

    // Pārrakstīta metode, kas attēlo informāciju par māju
    public override void DisplayInfo()
    {
        Console.WriteLine("Māja atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri.");
        Console.WriteLine("Tajā ir " + numberOfRooms + " istabas.");
        Console.WriteLine("Tas ir " + landType + " tips majā.");
    }

    // Pārdefinē abstrakto metodi, lai sniegtu aprakstu par māju
    public override string GetDescription()
    {
        return "Māja atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri. Tajā ir " + numberOfRooms + " istabas.";
    }
}

// Klase "Zemes gabals", kas manto "Nekustamais īpašums"
public class LandPlot : RealEstate
{
    // Zemes gabala tips (piemēram, lauksaimniecības, dzīvojamais uc.)
    private string landType;

    // Konstruktors, kas izsauc vecāko klases konstruktoru un inicializē zemes gabala tipu
    public LandPlot(string address, double area, string landType) : base(address, area)
    {
        this.landType = landType;
    }

    // Pārrakstīta metode, kas attēlo informāciju par zemes gabalu
    public override void DisplayInfo()
    {
        Console.WriteLine("Zemes gabals atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri.");
        Console.WriteLine("Tas ir " + landType + " tips zemes.");
    }

    // Pārdefinē abstrakto metodi, lai sniegtu aprakstu par zemes gabalu
    public override string GetDescription()
    {
        return "Zemes gabals atrodas adresē: " + address + ", ar kopējo platību " + area + " kvadrātmetri. Tas ir " + landType + " tips zemes.";
    }
}
