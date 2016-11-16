using System;

namespace ConsoleApplication
{
    public class Program
    {
    	//(double)?

    	//Задача 8 про спортсмена

    	//В первый день спортсмен пробежал x километров
    	//а затем он каждый день увеличивал пробег на 10% от предыдущего значения
    	//По данному числу y определите номер дня, на который пробег спортсмена составит не менее y километров.

		//Входные данные
		//Программа получает на вход действительные числа x и y

		//Выходные данные
		//Программа должна вывести одно натуральное число.

		//Примеры
		//входные данные
		//10
		//20

		//выходные данные
		//9
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №8. Спортсмен");
			int b;
			double x, y;

			b = 1;
			Console.Write("Километров x = ");
			x = double.Parse(Console.ReadLine());
			Console.WriteLine(x);
			Console.Write("Километров y = ");
			y = double.Parse(Console.ReadLine());
			Console.WriteLine(y);

			while (b > 0) 
				{
				Console.WriteLine(x);
				if (x == y)
						{
							Console.Write("День: ");
							Console.WriteLine(b);
							break;
						}
					x = x + (x * 0.1);
					b++;
				}

        }
    }
}
