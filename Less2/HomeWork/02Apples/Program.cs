

using System;

namespace ConsoleApplication
{
    public class Program
    {
		//Задача 2 о яблоках

    	//N школьников делят K яблок поровну, неделящийся остаток остается в корзинке. Сколько яблок останется в корзинке?
        //С клавиатуры вводятся N и K
    	//Пример входных данных:
    	//3
        //14
    	

    	//Выходные:
    	//2

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №2. Яблоки");
            int n, k, c;
            Console.Write("Кол-во школьников: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Кол-во яблок: ");
            k = int.Parse(Console.ReadLine());
            c = k % n;
            Console.Write("Яблок в корзине: ");
            Console.WriteLine(c);
        }
    }
}
