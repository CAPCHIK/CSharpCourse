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
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
