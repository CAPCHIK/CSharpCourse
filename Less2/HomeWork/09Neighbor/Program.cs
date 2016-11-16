using System;

namespace ConsoleApplication
{
    public class Program
    {
        
        //Задача 9 про соседние элементы


		//Входные данные
		//Сначала задано число N — количество элементов в массиве (1N100 ). Далее через пробел записаны N чисел — элементы массива. Массив состоит из целых чисел.

		//Выходные данные
		//Необходимо вывести количество элементов массива, у которых два соседа и которые при этом строго больше обоих своих соседей.

		//Примеры
		//входные данные
		//5
		//1 2 3	4 5
		//
		//выходные данные
		//0
		//входные данные
		//5
		//1 5 1 5 1

		//выходные данные
		//2
		public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №9. Соседние элементы");
			int n, k;
			Console.Write("Введите N = ");
			n = int.Parse(Console.ReadLine());
			int[] element  = new int[n];
			Console.Write("Введите элементы массива: ");
			for (int i = 0; i<=n; i++)
			{
				element[i] = int.Parse(Console.ReadLine());
			}
			k = 0;
			for (int i = 1; i<=n-1; i++)
			{
				if ( (element[i] > element[i-1]) & (element[i] > element[i+1]) )
						k++;
			}

			Console.Write ("К = ");
			Console.WriteLine (k);
        }
    }
}
		