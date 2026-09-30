class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public void ReadInfo()
    {
        Console.Write("Ange produktens namn: ");
        Name = Console.ReadLine();

        Console.Write("Ange pris: ");
        Price = double.Parse(Console.ReadLine());

        Console.Write("Ange antal: ");
        Quantity = int.Parse(Console.ReadLine());
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Produkt: {Name}");
        Console.WriteLine($"Pris: {Price} kr");
        Console.WriteLine($"Antal: {Quantity}");
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }
}