using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string Title, string Author, int Year)
        {
            this.Title = Title; 
            this.Author = Author;
            this.Year = Year;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"{Title} : {Author} : {Year}");
        }

        public bool check(int year)
        {
            if (year < Year) return true;
            else return false;
        }

    }
}
