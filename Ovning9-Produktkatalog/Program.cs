CreateProductCatalog();

static void CreateProductCatalog()
{
    Console.WriteLine("=== Produkt 1 ===");

    Product product1 = new Product();
    product1.ReadInfo();

    Console.WriteLine("\n=== Produkt 2 ===");

    Product product2 = new Product();
    product2.ReadInfo();


    Console.WriteLine("\n=== PRODUKTKATALOG ===");

    product1.PrintInfo();
    Console.WriteLine($"Totalpris: {product1.GetTotalPrice()} kr");

    Console.WriteLine();

    product2.PrintInfo();
    Console.WriteLine($"Totalpris: {product2.GetTotalPrice()} kr");


    double totalCost = product1.GetTotalPrice() + product2.GetTotalPrice();

    Console.WriteLine("\n=== TOTAL KOSTNAD ===");
    Console.WriteLine($"Sammanlagd kostnad: {totalCost} kr");
}
