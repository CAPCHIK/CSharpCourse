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

			int a1 = int.Parse(Console.ReadLine());
			int b1 = int.Parse(Console.ReadLine());
			int a2 = int.Parse(Console.ReadLine());
			int b2 = int.Parse(Console.ReadLine());
		if((a1 >=1 && a1 <=8) && (b1 >=1 && b1 <=8) && (a2 >=1 && a2 <=8) && (b2 >=1 && b2 <=8)){
			if(a1 == a2 && b1 == b2){
				Console.WriteLine("Нет");
			}else if((a1 == a2-1 || a1 == a2+1) && (b1 == b2-1 || b1 == b2+1)){
				Console.WriteLine("Да");
			}

        }
		}
    }
}
