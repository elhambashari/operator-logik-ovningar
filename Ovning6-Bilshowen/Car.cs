class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public void ReadInfo()
    {
        Console.Write("Ange bilmärke: ");
        Brand = Console.ReadLine();

        Console.Write("Ange modell: ");
        Model = Console.ReadLine();

        Console.Write("Ange färg: ");
        Color = Console.ReadLine();
    }

    public void ShowCar()
    {
        Console.WriteLine($"Din bil är en {Color} {Brand} {Model}.");
    }
}