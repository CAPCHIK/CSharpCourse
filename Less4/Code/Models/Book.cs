using System;

namespace Code.Models
{
    class Book
    {
        private string name;
        private string author;
        private int year;

        public int Year
        {
            get { return 234; }
        }

        public Book(string Name, string Author, int Year)
        {
            System.Console.WriteLine("Констркутор!");
            name = Name;
            author = Author;
            year = Year;
            PrintAbout();

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name : {name} Year : {year} Author : {author}");
        }

        public static void PrintAbout()
        {
            Console.WriteLine("Книги - это хорошо(наверно)");
        }
    }
}