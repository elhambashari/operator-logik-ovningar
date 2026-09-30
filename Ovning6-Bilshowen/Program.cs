CreateCarShow();

static void CreateCarShow()
{
    Console.WriteLine("=== Bil 1 ===");

    Car car1 = new Car();
    car1.ReadInfo();

    Console.WriteLine("\n=== Bil 2 ===");

    Car car2 = new Car();
    car2.ReadInfo();

    Console.WriteLine("\n=== BILSHOW ===");

    car1.ShowCar();
    car2.ShowCar();
}
