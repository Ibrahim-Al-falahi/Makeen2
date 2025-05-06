using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class BankAccount
    {
        public static int TotalAccount=0;


        public string Owner { get; set; }
        public int BankAccountNumber { get; set; }
        //public int Balance { get; set; }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { 
                if (value>0)
                {
                    balance = value;
                }
                 
            }
        }


        public BankAccount(string owner, int bankAccountNumber, int balance)
        {
            TotalAccount++;
            Owner = owner;
            BankAccountNumber = bankAccountNumber;
            Balance = balance;
        }


        public void Deposit()
        {
            Balance += 100;
        }
        public void Withdraw()
        {
            if (Balance >= 50)
            {
                
            Balance -= 50;
            }
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine(TotalAccount); 
        }


    }
}
