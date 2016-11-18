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
            int a=0;
            int b=0;
            Double c;
			Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
           a= Convert.ToInt32(Console.ReadLine());
           b= Convert.ToInt32(Console.ReadLine());
            c = Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
