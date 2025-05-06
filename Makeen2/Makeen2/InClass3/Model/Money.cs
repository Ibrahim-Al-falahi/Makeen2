using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3.Model
{
    internal class Money
    {

        public double Amount { get; set; }
        public Money(double amount)
        {
            Amount = amount;
        }

        public static Money operator +(Money a,Money b)
        {
            double val=a.Amount+b.Amount;
            return new Money(val);
        }

        public static Money operator -(Money a, Money b)
        {
            double val = a.Amount - b.Amount;
            return new Money(Math.Abs(val));
        }

        public static bool operator >(Money a, Money b)
        {
            if (a.Amount > b.Amount)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Money a, Money b)
        {
            if (a.Amount < b.Amount)
            {
                return true;
            }
            return false;
        }


    }
}
