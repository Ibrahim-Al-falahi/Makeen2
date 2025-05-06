namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            list.Add(new Dog());
            list.Add(new Cat());
            list.Add(new Cow());

            foreach (var item in list)
            {
                Console.WriteLine(item.MakeSound());
            }
        }
    }
}
