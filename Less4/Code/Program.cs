using System;
using Code.Models;
using Code.Models;

namespace Code
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Book sampleBook = new Book("sa", "ad", 342);
            var year = sampleBook.Year;
            sampleBook.PrintInfo();


            Point p = new Point();
            p.X = 4;
            var dist = p.Distance;
        }
    }
}
