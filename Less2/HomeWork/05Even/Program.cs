using System;

namespace ConsoleApplication
{
    public class Program
    {
    	//Задача 5 про четность

    	//Даны три целых числа A, B, C. Определить, есть ли среди них хотя бы одно четное и хотя бы одно нечетное.

		//Входные данные
		//Числа A, B, C, не превышающие по модулю 10000.

		//Выходные данные
		//Одна строка – "ДА" или "НЕТ".

		//Примеры
		//входные данные
		//3
		//4
		//5
		//выходные данные
		//ДА
		

		//входные данные
		//7
		//7
		//7
		//выходные данные
		//НЕТ
        public static void Main(string[] args)
        {

			Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			if ((a > 10000 || a < -10000) && (b > 10000 || b < -10000) && (c > 10000 || c < -10000) ){

					Console.WriteLine("НЕТ");

			}else{
				
				if(a % 2 == 0 || b % 2 == 0 || c % 2 == 0){

					if(a % 2 != 0 || b % 2 != 0 || c % 2 != 0){

						Console.WriteLine("ДА");

					}else{

						Console.WriteLine("НЕТ");

					}

					

				}else{

					Console.WriteLine("НЕТ");

				}

			}

        }
    }
}