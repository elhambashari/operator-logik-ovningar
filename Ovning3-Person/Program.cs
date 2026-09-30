Console.WriteLine("=== Person 1 ===");

Person person1 = new Person();

Console.Write("Namn: ");
person1.Name = Console.ReadLine();

Console.Write("Ålder: ");
person1.Age = int.Parse(Console.ReadLine());

Console.Write("Favoritfärg: ");
person1.FavoriteColor = Console.ReadLine();


Console.WriteLine("\n=== Person 2 ===");

Person person2 = new Person();

Console.Write("Namn: ");
person2.Name = Console.ReadLine();

Console.Write("Ålder: ");
person2.Age = int.Parse(Console.ReadLine());

Console.Write("Favoritfärg: ");
person2.FavoriteColor = Console.ReadLine();


Console.WriteLine("\n=== Presentation ===");

person1.Introduce();
person2.Introduce();
