class Burger
{
    public string Bread { get; set; }
    public string Meat { get; set; }
    public string Topping { get; set; }

    public void ReadInfo()
    {
        Console.Write("Vilket bröd vill du ha? ");
        Bread = Console.ReadLine();

        Console.Write("Vilket kött vill du ha? ");
        Meat = Console.ReadLine();

        Console.Write("Vilken topping vill du ha? ");
        Topping = Console.ReadLine();
    }

    public void DescribeBurger()
    {
        Console.WriteLine($"Din burgare har {Bread}, {Meat} och {Topping} som topping.");
    }
}