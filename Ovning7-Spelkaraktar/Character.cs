class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Power { get; set; }

    public void ReadInfo()
    {
        Console.Write("Ange karaktärens namn: ");
        Name = Console.ReadLine();

        Console.Write("Ange level: ");
        Level = int.Parse(Console.ReadLine());

        Console.Write("Ange power: ");
        Power = int.Parse(Console.ReadLine());
    }

    public void ShowStats()
    {
        Console.WriteLine($"Namn: {Name}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Power: {Power}");
    }

    public int CalculateStrength()
    {
        return Level * Power;
    }
}