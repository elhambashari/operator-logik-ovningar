Console.Write("Ange ett belopp i SEK: ");

string input = Console.ReadLine();

double sek = double.Parse(input);

Console.WriteLine($"Du angav {sek} SEK.");


Console.WriteLine("\nTillgängliga valutor:");
Console.WriteLine("EUR");
Console.WriteLine("GBP");
Console.WriteLine("JPY");
Console.WriteLine("USD");

Console.Write("\nVälj valuta: ");
string valuta = Console.ReadLine().ToUpper();

Console.WriteLine($"Du valde {valuta}.");


double convertedAmount = 0;

switch (valuta)
{
    case "EUR":
        convertedAmount = sek * 0.087;
        break;

    case "GBP":
        convertedAmount = sek * 0.075;
        break;

    case "JPY":
        convertedAmount = sek * 13.4;
        break;

    case "USD":
        convertedAmount = sek * 0.092;
        break;

    default:
        Console.WriteLine("Ogiltig valuta.");
        break;
}
if (convertedAmount > 0)
{
    Console.WriteLine($"{sek} SEK = {convertedAmount:F2} {valuta}");
}