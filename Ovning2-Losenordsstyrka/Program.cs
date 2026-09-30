Console.Write("Ange ett lösenord: ");
string password = Console.ReadLine();

bool hasEnoughLength = false;
bool hasUppercase = false;
bool hasLowercase = false;
bool hasNumber = false;
bool hasSpecialCharacter = false;


// Kontrollera längden
if (password.Length >= 8)
{
    hasEnoughLength = true;
}


// Kontrollera varje tecken i lösenordet
foreach (char c in password)
{
    if (char.IsUpper(c))
    {
        hasUppercase = true;
    }

    if (char.IsLower(c))
    {
        hasLowercase = true;
    }

    if (char.IsDigit(c))
    {
        hasNumber = true;
    }

    if (!char.IsLetterOrDigit(c))
    {
        hasSpecialCharacter = true;
    }
}


// Bedöm lösenordets styrka
if (hasEnoughLength &&
    hasUppercase &&
    hasLowercase &&
    hasNumber &&
    hasSpecialCharacter)
{
    Console.WriteLine("Lösenordet är Starkt.");
}
else if (hasEnoughLength &&
         hasUppercase &&
         hasLowercase &&
         (hasNumber || hasSpecialCharacter))
{
    Console.WriteLine("Lösenordet är Moderat.");
}
else
{
    Console.WriteLine("Lösenordet är Svagt.");
}