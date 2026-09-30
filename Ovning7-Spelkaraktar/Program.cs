CreateAndShowCharacters();

static void CreateAndShowCharacters()
{
    Console.WriteLine("=== Karaktär 1 ===");

    Character character1 = new Character();
    character1.ReadInfo();

    Console.WriteLine("\n=== Karaktär 2 ===");

    Character character2 = new Character();
    character2.ReadInfo();

    Console.WriteLine("\n=== KARAKTÄRER ===");

    character1.ShowStats();
    Console.WriteLine($"Styrka: {character1.CalculateStrength()}");

    Console.WriteLine();

    character2.ShowStats();
    Console.WriteLine($"Styrka: {character2.CalculateStrength()}");
}
