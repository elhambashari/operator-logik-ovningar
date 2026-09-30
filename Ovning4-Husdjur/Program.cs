CreateAndIntroducePets();

static void CreateAndIntroducePets()
{
    Console.WriteLine("=== Husdjur 1 ===");

    Pet pet1 = new Pet();
    pet1.ReadInfo();

    Console.WriteLine("\n=== Husdjur 2 ===");

    Pet pet2 = new Pet();
    pet2.ReadInfo();

    Console.WriteLine("\n=== Presentation ===");

    pet1.Introduce();
    pet2.Introduce();
}
