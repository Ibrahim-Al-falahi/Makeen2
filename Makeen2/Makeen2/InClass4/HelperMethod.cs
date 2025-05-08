using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass4
{
    internal class HelperMethod
    {
        public static void Print<T>(T obj)
        {
            Console.WriteLine(obj+" : "+typeof(T));
        }

    }
}
