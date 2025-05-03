namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine( dog.MakeSound());

            Console.WriteLine(cat.MakeSound());
        }

        public abstract class Animal
        {
            
            public virtual string MakeSound()
            {
                return"this animal sound like: ";
            }
        }
        public class Dog : Animal
        {
            public Dog()
            {
                
            }
            public override string MakeSound()
            {
                return base.MakeSound() +"Dog, it says WHOOF";
            }
        }

        public class Cat : Animal
        {
            public Cat()
            {

            }
            public override string MakeSound()
            {
                return base.MakeSound() + "Cat, it says MEAW";
            }
        }

    }
}
