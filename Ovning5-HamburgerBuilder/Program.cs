CreateAndDescribeBurgers();

static void CreateAndDescribeBurgers()
{
    Console.WriteLine("=== Burgare 1 ===");

    Burger burger1 = new Burger();
    burger1.ReadInfo();

    Console.WriteLine("\n=== Burgare 2 ===");

    Burger burger2 = new Burger();
    burger2.ReadInfo();

    Console.WriteLine("\n=== Dina burgare ===");

    burger1.DescribeBurger();
    burger2.DescribeBurger();
}
