namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light myLight = new Light(false, 50);
            Thermostat myThermostat = new Thermostat(false, 30);

            Controller controller = new Controller();

            Console.WriteLine("\nOperating Light");
            controller.Run(myLight);

            Console.WriteLine("\nOperating Thermostat");
            controller.Run(myThermostat);

        }
    }
}
