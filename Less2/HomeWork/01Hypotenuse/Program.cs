using System;

namespace ConsoleApplication
{
    public class Program
    {

    	//Задача 1 о гипотенузе
    	//Дано два числа a и b. Найдите гипотенузу треугольника с заданными катетами.

    	//В двух строках вводятся два числа (числа целые,положительные, не превышают 1000).

    	//Данные вводятся с клавиатуры, выводятся на консоль

    	//Пример: Входные данные
    	//3
		//4

		//Выходные
		//5.0


		//подсказка : int.Parse("23");
        public static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №1. Гепотенуза");
			int a, b;
			double c;
			Console.WriteLine("Введите значение катетов: ");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = Math.Sqrt(a*a+b*b);
			Console.Write("Гепотенуза = ");
			Console.WriteLine(c);

        }
    }
}
