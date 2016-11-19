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
			
            int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			if(a > b){

				int max = a;
				Console.WriteLine(max);

			}else if(b > a){

				int max = b;
				Console.WriteLine(max);

			}else{

				Console.WriteLine("Они равны!");

			}

        }
    }
}
