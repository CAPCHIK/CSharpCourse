using System;

namespace ConsoleApplication
{
    public class Program
    {


    	//Задача 7, анализ данных

    	//Входные данные
		//Вводится число N, а затем N чисел.

		//Выходные данные
		//Подсчитайте и выведите, сколько среди данных N чисел, крвтных трем.

		//Примеры
		//входные данные
		//3
		//1
		//2
		//3
		//выходные данные
		//1


		//входные данные
		//4
		//9
		//0
		//8
		//1
		//выходные данные
		//2
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №7. Анализ данных");
			int n, k, m;
			k = 0;
			Console.Write("Введите число N: ");
			n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				m = int.Parse(Console.ReadLine());
				if (m % 3 == 0)
				{
					k++;
				}
			}
			Console.Write("Количество чисел среди N, кратных трем = ");
			Console.WriteLine(k);

        }
    }
}
