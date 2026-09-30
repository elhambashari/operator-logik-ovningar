class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string FavoriteColor { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hej! Jag heter {Name}, jag är {Age} år gammal och min favoritfärg är {FavoriteColor}.");
    }
}