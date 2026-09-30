class Pet
{
    public string Name { get; set; }
    public string AnimalType { get; set; }
    public string FavoriteFood { get; set; }

    public void ReadInfo()
    {
        Console.Write("Vad heter ditt husdjur? ");
        Name = Console.ReadLine();

        Console.Write("Vilken typ av djur är det? ");
        AnimalType = Console.ReadLine();

        Console.Write("Vad är husdjurets favoritmat? ");
        FavoriteFood = Console.ReadLine();
    }

    public void Introduce()
    {
        Console.WriteLine($"Jag heter {Name}, jag är en {AnimalType} och jag älskar {FavoriteFood}!");
    }
}