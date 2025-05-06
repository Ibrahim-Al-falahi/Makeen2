namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Toyota","Yaris",2000);
            Car car = new Car("BMW", "M4", 2024,2);
            Truck truck = new Truck("Ford", "Raptor", 2020, 60);

            Console.WriteLine(vehicle.DisplayInfo());
            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(truck.DisplayInfo());

        }
    }
}
