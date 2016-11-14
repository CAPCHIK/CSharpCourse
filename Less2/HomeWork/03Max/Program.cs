using System;

namespace ConsoleApplication
{
    public class Program
    { 
    	//Задача 3, максимальное число 
    	//Даны два целых числа, каждое число записано в отдельной строке.
    	//Необходимо вывести максимальное число из введенных

    	//Пример
    	//Выходные
    	//1
    	//2

    	//Выходные
    	//2
        public static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.Unicode;
        	Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №3. Максимальное число");
			int a,b;
			Console.WriteLine("Введите два целых числа: ");
			a=int.Parse(Console.ReadLine());
			b=int.Parse(Console.ReadLine());
			Console.Write("Max = ");
			if (a > b)
				{
					Console.WriteLine(a);
				}
				else
				{
					Console.WriteLine(b);
				};
        }
    }
}
