class Ticket
{
    public string EventName { get; set; }
    public string Place { get; set; }
    public string SeatNumber { get; set; }

    public void ReadInfo()
    {
        Console.Write("Ange eventets namn: ");
        EventName = Console.ReadLine();

        Console.Write("Ange plats: ");
        Place = Console.ReadLine();

        Console.Write("Ange sittplats: ");
        SeatNumber = Console.ReadLine();
    }

    public void PrintTicket()
    {
        Console.WriteLine("\n🎫 KONCERTBILJETT 🎫");
        Console.WriteLine($"Event: {EventName}");
        Console.WriteLine($"Plats: {Place}");
        Console.WriteLine($"Sittplats: {SeatNumber}");
    }
}