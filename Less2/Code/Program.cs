using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var s = Console.ReadLine();
            Console.WriteLine("Привет World! " + args[0] + s);
            System.Console.WriteLine(Encoding.Unicode.CodePage);

            Console.ReadKey();
        }
    }
}
