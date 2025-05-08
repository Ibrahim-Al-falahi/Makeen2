namespace InClass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HelperMethod.Print("Hi");
            //HelperMethod.Print(5);
            //HelperMethod.Print(5.3);
            //HelperMethod.Print(true);

            MyArray<int> myArray=new MyArray<int>();

            myArray.Add(1);
            myArray.Add(2);
            myArray.Add(3);
            myArray.Count();
            myArray.Display();
            
        }
    }
}
