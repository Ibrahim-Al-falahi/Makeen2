using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass4
{
    internal class MyArray<T>
    {
        public T[] array;


        public void Add(T item)
        {
            if (array is null) { 
                array = new T[] {item};
            }
            else {

                T[] newArray = new T[array.Length+1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[array.Length] = item;
                array = newArray;
            }
        }
        public void Count()
        {
            Console.WriteLine("Count: "+array.Length);
        }

        public void Display()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("print "+array[i]);
            }
        }



    }
}
