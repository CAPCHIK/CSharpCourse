using System;

namespace ConsoleApplication
{
    public class Program
    {
		//Задача 4 про шахматы

    	//Поле шахматной доски определяется парой чисел (a, b), каждое от 1 до 8
    	//первое число задает номер столбца, второе – номер строки
    	//Заданы две клетки. Определите, может ли шахматный король попасть с первой клетки на вторую за один ход.

		//Входные данные
		//Даны 4 целых числа от 1 до 8 каждое, первые два задают начальную клетку
		//вторые два задают конечную клетку
		//Начальная и конечная клетки не совпадают. Числа записаны в отдельных строках.

		//Выходные данные
		//Программа должна вывести ДА, если из первой клетки ходом короля можно попасть во вторую
		//или НЕТ в противном случае.
        
        //Примеры
		//входные данные
		//4
		//4
		//5
		//5


		//выходные данные
		//ДА

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");

			Console.WriteLine("Задача №4. Шахматы"); 
			int a, b, a1, b1;
			Console.WriteLine("Введите числа: ");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine()); 
			a1 = int.Parse(Console.ReadLine());
			b1 = int.Parse(Console.ReadLine());
			if (((a == a1-1) & (b == b1)) | ((a == a1) & (b == b1-1)) | ((a == a1-1) & (b == b1-1))) 
				{
					Console.WriteLine("ДА");
				}
				else	
				{
					Console.WriteLine("НЕТ");
				}

        }
    }
}
