using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass2.Models
{
    internal class HelperFunction
    {
        public static void CalculationGrowth(double a, double b)
        {
            Console.WriteLine("Your Growth : "+a * b); 
        }
        public static double CalculationNet(double a, double b)
        {
            double growth = a * b;
            return growth - (growth * 0.03);
        }

    }
}
