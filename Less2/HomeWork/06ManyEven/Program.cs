using System;

namespace ConsoleApplication
{
    public class Program
    {
    	//Задача 6, список четных чисел
    	//Входные данные
		//Вводятся целые числа a и b. Гарантируется, что a не превосходит b

		//Выходные данные
		//Выведите (через пробел) все четные числа от a до b (включительно).

		//Примеры
		//входные данные
		//2
		//5
		
		//выходные данные
		//2 4 
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №6. Список четных чисел");
			int a, b;  
			Console.Write (" ");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			Console.Write ("Четные числа от a до b: ");
			for (int i = a ; i <= b ; i++)
			{

				if (i % 2 == 0)   
					{
						Console.Write (i);
						Console.Write (" ");
					}
			}
        }
    }
}
