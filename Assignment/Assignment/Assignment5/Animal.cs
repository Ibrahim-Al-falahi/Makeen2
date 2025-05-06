using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public abstract string MakeSound();
    }
}
