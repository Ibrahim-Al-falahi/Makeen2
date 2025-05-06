using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InClass2.Models
{
    internal class PhoneBook
    {
        private int size;
        private string[] name;
        private int[] number;

        public PhoneBook(int size)
        {
            this.size = size;
            this.name = new string[size];
            this.number = new int[size];
        }



        public int this[int index,string s]
        {
            get{
                for (int i = 0; i < size; i++)
                {
                    if (this.name[i]==s)
                    {
                        return number[i];
                    }
                }
                return -1;
            }
            set
            {
                this.name[index]=s;
                number[index] = value;


            }
         }


        //public void AddEntry(int index, string name, int number)
        //{
        //    if (index<size)
        //    {

        //        this.name[index] = name;
        //        this.number[index] = number;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Look at the size");
        //    }
        //}

        //public void GetRecord(int index)
        //{
        //    if (index<size)
        //    {

        //    Console.WriteLine($"{name[index]} : {number[index]}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Look at the size");
        //    }
        //}

        //public void GetRecord(string name)
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        if (this.name[i].ToLower()==name.ToLower())
        //        {
        //            Console.WriteLine($"{this.name[i]} : {number[i]}");
        //            return;
        //        }
        //    }
        //    Console.WriteLine("not found");

        //}
    }

}

