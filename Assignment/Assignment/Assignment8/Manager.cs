﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
    }
}
